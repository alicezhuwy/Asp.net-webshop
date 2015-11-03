using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Management_ManageWebsite : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void gvProducts_RowEditing1(object sender, GridViewEditEventArgs e)
    {
        //Get Selected row
        GridViewRow row = gvProducts.Rows[e.NewEditIndex];

        //Get Id of selected product
        int rowId = Convert.ToInt32(row.Cells[1].Text);

        //Redirect user to ManageProduct along with the selected rowId
        Response.Redirect("~/Pages/Management/ManageProduct.aspx?id=" + rowId);
    }


}