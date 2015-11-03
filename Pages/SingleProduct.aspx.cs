using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Pages_SingleProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillPage();
    }

    private void FillPage()
    {
        //Get selected product's data
        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            ProductModel productModel = new ProductModel();
            Product product = productModel.GetProduct(id);
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();

            //Fill Page with data
            lblColor.Text = " " + product.Color;
            lblPrice.Text = " $" + product.Price;
            lblTitle.Text = product.Name;
            lblDescription.Text = product.Description;
            lblProductNum.Text = "Product Number: "+ id.ToString();
            imgProdcut.ImageUrl = "~/Image/Products/" + product.Image;

            //Retrieve supplier
            int supplierId = product.SupplierID;
            Supplier supplier = db.Suppliers.Find(supplierId);
            lblSupplier.Text = "By " + supplier.Name;


            //Fille amount dropdown list with numbers 1-30;
            int[] quantity = Enumerable.Range(1, 30).ToArray();
            ddlQuantity.DataSource = quantity;
            ddlQuantity.AppendDataBoundItems = true;
            ddlQuantity.DataBind();
        }
    }


    private bool CheckProductId(HashSet<int> orderProductId, int id)
    {

        Boolean flag = false;

        foreach (int productId in orderProductId)
        {
            if (productId == id)
            {
                flag = true;
            }
        }
        return flag;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        HashSet<int> orderProductId = new HashSet<int>();
        //List<int> orderProductId = new List<int>();
        //List<int> newList = new List<int>();

        int clientId = Convert.ToInt32(Application["clientId"]);
        int id = Convert.ToInt32(Request.QueryString["id"]);
        int quantity = Convert.ToInt32(ddlQuantity.SelectedValue);
        CartModel cartModel = new CartModel();

        if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            if (HttpContext.Current.Application["clientName"] != null)
            {

                if (HttpContext.Current.Application["productid"] != null)
                {

                    orderProductId = (HashSet<int>)HttpContext.Current.Application["productID"];
                    
                    //string combindedString = string.Join(",", orderProductId);
                    Boolean flag = CheckProductId(orderProductId, id);
               
                    if (flag == true)
                    {
                        lblResult.Text = cartModel.UpdateQty(id, quantity, clientId);
                    }
                    else
                    {
                        Cart cart = new Cart
                        {
                            Quantity = quantity,
                            ClientID = clientId,
                            DataPurchased = DateTime.Now,
                            IsInCart = true,
                            ProductID = id
                        };

                        lblResult.Text = cartModel.InsertCart(cart); 
                    }                 
                }

                else
                {
                    Cart cart = new Cart
                    {
                        Quantity = quantity,
                        ClientID = clientId,
                        DataPurchased = DateTime.Now,
                        IsInCart = true,
                        ProductID = id
                    };

                    lblResult.Text = cartModel.InsertCart(cart);
                }

                orderProductId.Add(id);
                //string combindedString = string.Join(",", orderProductId);
                //lbltest1.Text = combindedString;
                HttpContext.Current.Application["productID"] = orderProductId;
                //lbltest.Text = Application["productID"].ToString();

                Response.Redirect("~/Pages/ShoppingCart.aspx", false);
              }

            else
            {
                lblResult.Text = "Please log in to order items";
            }

        }
    
    }

}

//int clientId = Convert.ToInt32(Application["clientId"]);
//int id = Convert.ToInt32(Request.QueryString["id"]);
//int quantity = Convert.ToInt32(ddlQuantity.SelectedValue);
//Cart cart = new Cart
//{
//    Quantity = quantity,
//    ClientID = clientId,
//    DataPurchased = DateTime.Now,
//    IsInCart = true,
//    ProductID = id
//};

//CartModel cartModel = new CartModel();
//lblResult.Text = cartModel.InsertCart(cart); 


//foreach (int productId in orderProductId)
//{

//    if (productId != id)
//    {

//    }

//    else
//    {
//        lbltest2.Text = cartModel.UpdateQty(id, quantity, clientId);

//    }
// }

//foreach (int productId in orderProductId)
//{

//    if (productId != id)
//    {
//        newList.Add(id);
//    }
//}

//newList.AddRange(orderProductId.Distinct());
//HttpContext.Current.Application["productID"] = newList;
