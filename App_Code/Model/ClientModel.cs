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
/// <summary>
/// Summary description for Client
/// </summary>
public class ClientModel
{
    public string InsertClient(Client client)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
            db.Clients.Add(client);
            db.SaveChanges();

            return client.Name + " was successfully inserted!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateClient(int id, Client client)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();

            //Fetch object from db
            Client p = db.Clients.Find(id);

            p.Name = client.Name;
            p.Password = client.Password;
            p.PhoneNumber = client.PhoneNumber;
            p.EmailAddress = client.EmailAddress;
            p.HomeAddress = client.HomeAddress;

            db.SaveChanges();
            return client.Name + " was successfully updated!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public Client GetClient(int id)
    {
        try
        {
            using (ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities())
            {
                Client client = db.Clients.Find(id);
                return client;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public string DeleteClient(int id)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
            Client client = db.Clients.Find(id);

            db.Clients.Attach(client);
            db.Clients.Remove(client);
            db.SaveChanges();

            return client.Name + " was successfully deleted!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public List<Client> GetAllClients()
    {
        try
        {
            using (ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities())
            {
                List<Client> clients = (from x in db.Clients
                                          select x).ToList();
                return clients;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }
}