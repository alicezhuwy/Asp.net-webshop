using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_CheckOut : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<Cart> carts = (List<Cart>)Application["ShoppingCart"];

        string clientName = Application["clientName"].ToString();
        int clientId = Convert.ToInt32(Application["clientId"]);
        DateTime date = DateTime.Now;
        double totalAmount = Convert.ToDouble(Application["totalAmount"]);

        //Create new record in database
        OrderModel orderModel = new OrderModel();
        Order order = new Order
        {
            ClientID = clientId,
            OrderDate = date,
            Status = "Waitting",
            TotalAmount = totalAmount,
        };
        string id = orderModel.InsertOrder(order);

        //Fill page
        lblName.Text = clientName;
        lblDate.Text = date.ToString();
        lblStatus.Text = "Waitting";
        lblAmount.Text = "$ " + totalAmount.ToString();
        lblNumber.Text = id;

        CartModel cartModel = new CartModel();
        cartModel.MarkOrderAsPaid(carts);
        Application["ShoppingCart"] = null;
    }
}