using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_WebShop : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!this.IsPostBack)
        {
          DropDownList1_SelectedIndexChanged(sender, e);
        }

    }



    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {


        List<Product> products = CreateList();

        if (products != null)
        {
            //Check if product in DB
            foreach (Product product in products)
            {
                Panel productPanel = new Panel();
                ImageButton imageButton = new ImageButton();
                Label lblName = new Label();
                Label lblPrice = new Label();

                imageButton.ImageUrl = "~/Image/Products/" + product.Image;
                imageButton.CssClass = "productImage";
                imageButton.PostBackUrl = "~/Pages/SingleProduct.aspx?id=" + product.ID;

                lblName.Text = product.Name;

                lblPrice.Text = "$" + product.Price;


                //Child Control
                productPanel.Controls.Add(imageButton);
                productPanel.Controls.Add(new Literal { Text = "<br />" });
                productPanel.Controls.Add(lblName);
                productPanel.Controls.Add(new Literal { Text = "<br />" });
                productPanel.Controls.Add(lblPrice);

                //Conect dynamic panel to parent panel
                panAllProduct.Controls.Add(productPanel);
            }
        }

        else
        {
            panAllProduct.Controls.Add(new Literal { Text = "Sorry, no match result found." });
        }

    }

    private List<Product> CreateList()
    {
        ProductModel productModel = new ProductModel();
        List<Product> products = new List<Product>();

        if (ddlList.SelectedItem.Value == "(All)" || ddlList.SelectedIndex < 1)
        {
            products = productModel.GetAllProducts();
        }//Get a list of all products in DB

        else
        {
            
            String ID = ddlList.SelectedItem.Value;
            int id = Convert.ToInt32(ID);
            products = productModel.GetProductByCategory(id);
        }

        return products;
    }
}

//private void ShowAllProduct()
//{
//    //Get a list of all products in DB
//    ProductModel productModel = new ProductModel();
//    List<Product> products = productModel.GetAllProducts();
//    if (products != null)
//    {
//        //Check if product in DB
//        foreach (Product product in products)
//        {
//            Panel productPanel = new Panel();
//            ImageButton imageButton = new ImageButton();
//            Label lblName = new Label();
//            Label lblPrice = new Label();

//            imageButton.ImageUrl = "~/Image/Products/" + product.Image;
//            imageButton.CssClass = "productImage";
//            imageButton.PostBackUrl = "~/Pages/SingleProduct.aspx?id=" + product.ID;

//            lblName.Text = product.Name;

//            lblPrice.Text = "$" + product.Price;


//            //Child Control
//            productPanel.Controls.Add(imageButton);
//            productPanel.Controls.Add(new Literal { Text = "<br />" });
//            productPanel.Controls.Add(lblName);
//            productPanel.Controls.Add(new Literal { Text = "<br />" });
//            productPanel.Controls.Add(lblPrice);

//            //Conect dynamic panel to parent panel
//            panAllProduct.Controls.Add(productPanel);
//        }
//    }

//    else
//    {
//        panAllProduct.Controls.Add(new Literal { Text = "Sorry, no match result found." });
//    }
//}


            
