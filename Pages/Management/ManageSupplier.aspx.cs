using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Management_ManageSupplier : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private Supplier CreateSupplier()
    {
        Supplier p = new Supplier();
        p.Name = txtName.Text;
        p.PhoneNumber = txtNumber.Text;
        p.EmailAddress = txtEmail.Text;

        return p;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SupplierModel model = new SupplierModel();
        Supplier c = CreateSupplier();

        lblResult.Text = model.InsertSupplier(c);
        Response.Redirect("~/Pages/Management/ManageWebsite.aspx", false);
    }

   
}