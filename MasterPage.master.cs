using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class MasterPage : System.Web.UI.MasterPage
{
    CartModel cartModel = new CartModel();

    protected void Page_Load(object sender, EventArgs e)
    {
        
        //ClientModel clientModel = new ClientModel();
        //int id = Convert.ToInt32(Session["clientId"]);
        //Client client = clientModel.GetClient(id);
        //String clientName = client.Name;

        //if (Request.Cookies["Name"] != null)
        if (Application["clientId"] != null)
        {
            lnkLogIn.Visible = false;
            lnkRegister.Visible = false;

            lnkCart.Visible = true;
            btnLogOut.Visible = true;

            String name = Application["clientName"].ToString();
            //lnkCart.Text = "Welcome back " + name + " !";
            
            int clientId = Convert.ToInt32(Application["clientId"]);
            lnkCart.Text = string.Format("{0} ({1})", "My Cart", cartModel.GetAmountOfOrders(clientId));
        }
        else
        {
            lnkLogIn.Visible = true;
            lnkRegister.Visible = true;

            lnkCart.Visible = false;
            btnLogOut.Visible = false;
        }
    }
    protected void btnLogOut_Click(object sender, EventArgs e)
    {

        //Mark the data in cart as paid
        List<Cart> carts = (List<Cart>)Application["ShoppingCart"];
        cartModel.MarkOrderAsPaid(carts);
        Application["ShoppingCart"] = null;

        Application["clientName"] = null;
        Application["clientId"] = null;
        Application["productID"] = null;



        Response.Redirect("~/Pages/AboutUs.aspx");
    }
}
