using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Accounts_AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_click(object sender, EventArgs e)
    {
        if (Application["clientName"] != null)
        {
            lblResult.Text = ("You are login as a customer, please log out first.");
        }
        else
        {
            if (txtName.Text.Trim() == "Admin" && txtPassword.Text.Trim() == "admin")
            {
                Response.Redirect("~/Pages/Management/ManageWebsite.aspx");
                //Session[clientName] = txtName.Text;
            }
            else
            {
                lblResult.Text = ("Access Denied");
                // Session.Abandon();
            }
        }

    }
}