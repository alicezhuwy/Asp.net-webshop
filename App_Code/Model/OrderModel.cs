using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderModel
/// </summary>
public class OrderModel
{
    public string InsertOrder(Order order)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
            db.Orders.Add(order);
            db.SaveChanges();

            return order.ID.ToString();
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateOrder(int id, Order order)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();

            //Fetch object from db
            Order p = db.Orders.Find(id);

            p.ClientID = order.ClientID;
            p.Status = order.Status;
            p.TotalAmount = order.TotalAmount;
            p.OrderDate = order.OrderDate;

            db.SaveChanges();
            return order.ID + " was successfully updated!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteOrder(int id)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
            Order order = db.Orders.Find(id);

            db.Orders.Attach(order);
            db.Orders.Remove(order);
            db.SaveChanges();

            return order.ID + " was successfully delected!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
}