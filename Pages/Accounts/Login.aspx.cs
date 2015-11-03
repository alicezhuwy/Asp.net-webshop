using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Pages_Accounts_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnsubmit_click(object sender, EventArgs e)
    {
        ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
        ClientModel clientModel = new ClientModel();
        List<Client> clients = clientModel.GetAllClients();

        String clientId = "";

        if (clients != null)
        {
            //Check if product in DB
            foreach (Client client in clients)

            {
                if (client.Name == txtName.Text.Trim() && client.Password == txtPassword.Text.Trim() && client.ActiveUser == true)
                {        
                        int Id = client.ID;
                        Application["clientId"] = Id;
                        Application["clientName"] = client.Name;

                        //Redirect page to WebShop after lable showing 
                        HtmlMeta meta = new HtmlMeta();
                        meta.HttpEquiv = "Refresh";                     
                        lblResult.Text =  Application["clientName"].ToString() + ", your login is successful!";
                        meta.Content = "3; url = /ZHUW15/asp_practical/Pages/WebShop.aspx";
                        this.Page.Controls.Add(meta);
                 
                }

                else if (client.Name == txtName.Text.Trim() && client.Password == txtPassword.Text.Trim() && client.ActiveUser == false)
                {
                    lblResult.Text = ("Sorry, this account is disable, please contact us for further help.");
                }
                else
                {
                    lblResult.Text = ("Invalid username or password!");
                    
                }
            }
            
        }

    }
}