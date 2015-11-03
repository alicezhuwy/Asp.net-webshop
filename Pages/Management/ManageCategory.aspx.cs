using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Management_ManageCategory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private Category CreateCategory()
    {
        Category p = new Category();
        p.Name = txtCategory.Text;
        p.Description = txtDescription.Text;

        return p;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        CategoryModel model = new CategoryModel();
        Category c = CreateCategory();

        lblResult.Text = model.InsertCategory(c);
        Response.Redirect("~/Pages/Management/ManageWebsite.aspx", false);
    }

}