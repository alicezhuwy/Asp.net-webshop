using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Net.Mail;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Net;


public partial class Pages_Accounts_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ZHUW15sqlserver1"].ConnectionString);
        //conn.Open();
        //string checkClient = "select count(*) from Client where Name = '"+ txtName.Text +"'";
        //SqlCommand com = new SqlCommand(checkClient, conn);
        //int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
        //if(temp == 1)
        //{
        //    Response.Write("Name you entered is exists, please choose another one.");
        //}
        //conn.Close();

    }

    private Client CreateClient()
    {
        Client client = new Client();

        client.Name = txtName.Text;
        client.EmailAddress = txtEmailAddress.Text;
        //string encryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "SHA1");
        client.Password = txtPassword.Text;
        client.PhoneNumber = txtPhoneNumber.Text;
        client.HomeAddress = txtHomeAddress.Text;
        client.ActiveUser = true;

        return client;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            ClientModel clientModel = new ClientModel();
            Client client = CreateClient();
  
            //Redirect to login page
            HtmlMeta meta = new HtmlMeta();
            meta.HttpEquiv = "Refresh";
            lblResult.Text = clientModel.InsertClient(client);
            meta.Content = "3; url = /ZHUW15/asp_practical/Pages/Accounts/Login.aspx";
            this.Page.Controls.Add(meta);

            //SendEmail();
        }
    }

    protected override void OnError(EventArgs e)
    {
        Exception ex = Server.GetLastError();

        Application["ExceptionObject"] = ex;

        Server.ClearError();

        Server.Transfer("DisplayErrors.aspx?from=RegistrationPage");

    }

    //private void SendEmail()
    //{
    //    string to = txtEmailAddress.Text;
    //    string from = "qualityhatshop@gmail.com";
    //    string fromPassword = "unitecunitec";
    //    string subject = "Welcome To Quality Hat!";
    //    using (MailMessage mm = new MailMessage(from, to))
    //    {
    //        mm.Subject = subject;
    //        mm.Body = "Dear " + txtName.Text + ":" + System.Environment.NewLine + System.Environment.NewLine + "User Name: " + txtName.Text + System.Environment.NewLine + "Password: " + txtPassword.Text;
    //        mm.IsBodyHtml = false;
    //        SmtpClient smtp = new SmtpClient();
    //        smtp.Host = "smtp.gmail.com";
    //        smtp.EnableSsl = true;
    //        NetworkCredential NetworkCred = new NetworkCredential(from, fromPassword);
    //        smtp.UseDefaultCredentials = true;
    //        smtp.Credentials = NetworkCred;
    //        smtp.Port = 587;
    //        smtp.Send(mm);
    //    }
    //}

}