using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Pages_ShoppingCart : System.Web.UI.Page
{
    ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();

    protected void Page_Load(object sender, EventArgs e)
    {
        //Get client ID from login page
        int clientId = Convert.ToInt32(Application["clientId"]);
        GetItemsInCart(clientId);
    }

    private void GetItemsInCart(int clientId)
    {
        CartModel cartModel = new CartModel();
        double subTotal = 0;
        double taxRate = 0.15;
        double shippingFee = 10;

        //Generate HTML for each item in purchaseList
        List<Cart> purchaseList = cartModel.GetOrdersFromeCart(clientId);
        CreateCartTable(purchaseList, out subTotal);

        //Add totals 
        double tax = subTotal * taxRate;
        double totalAmount = subTotal + tax + shippingFee;

        //Display all above
        litTotal.Text = "$" + subTotal;
        litTax.Text = "$" + tax;
        litTotalAmount.Text = "$" + totalAmount;

        Application["totalAmount"] = totalAmount;
    }

    private void CreateCartTable(List<Cart> purchaseList, out double subTotal)
    {
        ProductModel productModel = new ProductModel();
        subTotal = new double();

        //Create image button
        foreach(Cart cart in purchaseList)
        {
            Product product = productModel.GetProduct(cart.ProductID);

            ImageButton btnImage = new ImageButton
            {
                ImageUrl = string.Format("~/Image/Products/{0}", product.Image),
                PostBackUrl = string.Format("~/Pages/SingleProduct.aspx?id={0}", product.ID)
            };

        //Create delete link
            LinkButton lnkDelete = new LinkButton
            {
                PostBackUrl = string.Format("~/Pages/ShoppingCart.aspx?id={0}", cart.ID),
                Text = "Delete Item",
                ID = "del" + cart.ID
            };

            //Add an onClick evernt
            lnkDelete.Click += Delete_Item;

            //Create drop down list for choose quantity, same as singleproduct page, from 1 to 30
            int[] quantity = Enumerable.Range(1, 30).ToArray();
            DropDownList ddlQuantity = new DropDownList
            {
                DataSource = quantity,
                AppendDataBoundItems = true,
                //Page refresh when select from dropdown list, and total amount will caculate again
                AutoPostBack = true,
                //Record the ID for later
                ID = cart.ID.ToString()
            };

            //Bind data when works on dynamic page
            ddlQuantity.DataBind();
            ddlQuantity.SelectedValue = cart.Quantity.ToString();
            ddlQuantity.SelectedIndexChanged += ddlQuantity_SelectedIndexChanged;

            //Create HTML table with 2 rows
            Table table = new Table { CssClass = "cartTable" };
            TableRow first = new TableRow();
            TableRow second = new TableRow();

            //Create 6 cells for row first
            TableCell firstA = new TableCell { RowSpan = 2, Width = 100};
            TableCell firstB = new TableCell { Text = string.Format("<h4>{0}</h4><br/>{1}<br/>In Stock", product.Name, "Product NO.: " + product.ID), HorizontalAlign = HorizontalAlign.Left, Width = 380};
            TableCell firstC = new TableCell { Text = "Unit Price<hr/>"};
            TableCell firstD = new TableCell { Text = "QUantity<hr/>"};
            TableCell firstE = new TableCell { Text = "Total Amount<hr/>"};
            TableCell firstF = new TableCell { };

            //Create 6 cells for row second
            TableCell secondA = new TableCell { };
            TableCell secondB = new TableCell { Text = "$" + (double)product.Price };
            TableCell secondC = new TableCell { };
            TableCell secondD = new TableCell { Text = "$" + Math.Round((cart.Quantity * (double)product.Price), 2)};
            TableCell secondE = new TableCell { };
            TableCell secondF = new TableCell { };

            //Set controls
            firstA.Controls.Add(btnImage);
            firstF.Controls.Add(lnkDelete);
            secondC.Controls.Add(ddlQuantity);

            //Add cells to first
            first.Cells.Add(firstA);
            first.Cells.Add(firstB);
            first.Cells.Add(firstC);
            first.Cells.Add(firstD);
            first.Cells.Add(firstE);
            first.Cells.Add(firstF);

            //Add cells to row second
            second.Cells.Add(secondA);
            second.Cells.Add(secondB);
            second.Cells.Add(secondC);
            second.Cells.Add(secondD);
            second.Cells.Add(secondE);
            second.Cells.Add(secondF);

            //Add rows to table
            table.Rows.Add(first);
            table.Rows.Add(second);

            //Add table to panel 
            pnlShoppingCart.Controls.Add(table);

            //Add total amount to subtotal
            subTotal += (cart.Quantity * (double)product.Price);
        };

        //Add current client's shopping to his/her shopping cart application
        Application["shoppingCart"] = purchaseList;
    }

    private void ddlQuantity_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList qtyList = (DropDownList)sender;
        int quantity = Convert.ToInt32(qtyList.SelectedValue);
        int cartId = Convert.ToInt32(qtyList.ID);

        //Update quantity
        CartModel cartModel = new CartModel();
        cartModel.UpdateQuantity(cartId, quantity);

        Response.Redirect("~/Pages/ShoppingCart.aspx", false);
    }

    private void Delete_Item(object sender, EventArgs e)
    {

        LinkButton itemLink = (LinkButton)sender;
        string link = itemLink.ID.Replace("del", "");
        
        int cartId = Convert.ToInt32(link);
        Cart cart = db.Carts.Find(cartId);
        int productId = cart.ProductID;

        //Delete item
        CartModel cartModel = new CartModel();
        cartModel.DeleteCart(cartId);

        HashSet<int> orderProductId = (HashSet<int>)HttpContext.Current.Application["productID"];
        orderProductId.RemoveWhere(s => s == productId);
        Application["productID"] = orderProductId;
        Response.Redirect("~/Pages/ShoppingCart.aspx", false);
    }


    protected void btnClear_Click(object sender, EventArgs e)
    {
        List<Cart> carts = (List<Cart>)Application["ShoppingCart"];

        CartModel cartModel = new CartModel();
        
            //+ id.ToString();
        foreach(Cart cart in carts)
        {
            int id = cart.ID;
            cartModel.DeleteCart(id);
        }

        Application["ShoppingCart"] = null;
        Application["productID"] = null;

        HtmlMeta meta = new HtmlMeta();
        meta.HttpEquiv = "Refresh";
        meta.Content = "3; url = /ZHUW15/asp_practical/Pages/WebShop.aspx";
        this.Page.Controls.Add(meta);
    }

    //Checkout button
    protected void btnCheckOut_Click(object sender, EventArgs e)
    {
        //Check if shopping is empty
        if (Application["productID"] != null)
        {
            Response.Redirect("~/Pages/CheckOut.aspx", false);
        }
        else
        {
            string clientName = Application["clientName"].ToString();
            lblresult.Text = "Hi, " + clientName + " your shopping cart is empty!";
        }
    }
}