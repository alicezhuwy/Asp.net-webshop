using System;
using System.Collections;
using System.IO;

public partial class Pages_Management_ManageProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetImages();

            //Check if the url contains an id parameter
            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                FillForm(id);
            }
        }
         
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ProductModel productModel = new ProductModel();
        Product product = CreateProduct();

        if(!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
        {
            //ID exists then upadte existing row
            int id = Convert.ToInt32(Request.QueryString["id"]);
            lblResult.Text = productModel.UpdateProduct(id, product);
        }
        else
        {
            //ID dose not xist then creat a new row
            lblResult.Text = productModel.InsertProduct(product);
        }

        Response.Redirect("~/Pages/Management/ManageWebsite.aspx", false);
    }

    private void FillForm(int id)
    {
        //Get selected product from DB
        ProductModel productmodel = new ProductModel();
        Product product = productmodel.GetProduct(id);

        //Fill textboxes
        txtDescription.Text = product.Description;
        txtName.Text = product.Name;
        txtColor.Text = product.Color;
        txtPrice.Text = product.Price.ToString();
       
        //Set dropdpwn list value
        ddlImage.SelectedValue = product.Image;
        ddlCategory.SelectedValue = product.CategoryID.ToString();
        ddlSupplier.SelectedValue = product.SupplierID.ToString();
    }

    private void GetImages()
    {
        try
        {
            //Get all filepaths
            string[] images = Directory.GetFiles(Server.MapPath("~/Image/Products/"));

            //Get all filenames and add them to an arraylist
            ArrayList imageList = new ArrayList();
            foreach (string image in images)
            {
                string imageName = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                imageList.Add(imageName);
            }

            //Set the arrayList as the dropdownview's datasource and refresh
            ddlImage.DataSource = imageList;
            ddlImage.AppendDataBoundItems = true;
            ddlImage.DataBind();
        }
        catch (Exception e)
        {
            lblResult.Text = e.ToString();
        }
    }
    
    private Product CreateProduct()
    {
        Product product = new Product();

        product.Name = txtName.Text;
        product.Price = Convert.ToInt32(txtPrice.Text);
        product.CategoryID = Convert.ToInt32(ddlCategory.Text);
        product.Description = txtDescription.Text;
        product.Color = txtColor.Text;
        product.SupplierID = Convert.ToInt32(ddlSupplier.Text);
        product.Image = ddlImage.SelectedValue;

        return product;
    }
    
}