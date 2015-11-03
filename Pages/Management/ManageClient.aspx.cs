using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Configuration;

public partial class Pages_Management_ManageClient : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    private Client CreateClient()
    {
        Client client = new Client();

        client.Name = txtName.Text;
        client.EmailAddress = txtEmail.Text;
        string encryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "SHA1");
        client.Password = encryptedPassword;
        client.PhoneNumber = txtNumber.Text;
        client.HomeAddress = txtHomeAdd.Text;
        return client;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
            ClientModel clientModel = new ClientModel();
            Client client = CreateClient();
            lblResult.Text = clientModel.InsertClient(client);
    }


}