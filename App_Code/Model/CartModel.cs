using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CartModel
/// </summary>
public class CartModel
{
    public string InsertCart(Cart cart)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
            db.Carts.Add(cart);
            db.SaveChanges();

            return cart.DataPurchased + " was successfully inserted!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateCart(int id, Cart cart)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();

            //Fetch object from db
            Cart p = db.Carts.Find(id);

            p.ClientID = cart.ClientID;
            p.ProductID = cart.ProductID;
            p.Status = cart.Status;
            p.TotalCost = cart.TotalCost;
            p.IsInCart = cart.IsInCart;
            p.DataPurchased = cart.DataPurchased;

            db.SaveChanges();
            return cart.DataPurchased + " was successfully updated!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteCart(int id)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
            Cart cart = db.Carts.Find(id);

            db.Carts.Attach(cart);
            db.Carts.Remove(cart);
            db.SaveChanges();

            return cart.DataPurchased + " was successfully deleted!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    //Retrieve current objects in the shopping cart
    public List<Cart> GetOrdersFromeCart(int clientId)
    {
        ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
        List<Cart> orders = (from x in db.Carts
                                 where x.ClientID == clientId
                                 && x.IsInCart
                                 orderby x.DataPurchased
                                 select x).ToList();
        return orders;
    }

    //Return total number of the added products
    public int GetAmountOfOrders(int clientId)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
            int amount = (from x in db.Carts
                          where x.ClientID == clientId
                          && x.IsInCart
                          select x.Quantity).Sum();
            return amount;
        }
        catch
        {
            return 0;
        }
    }

    //Update qty from shopping cart page
    public void UpdateQuantity (int id, int quantity)
    {
        ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
        Cart cart = db.Carts.Find(id);
        cart.Quantity = quantity;

        //Save changes to database
        db.SaveChanges();
    }

    //Update qty of same product from singleProduct page 
    public string UpdateQty (int productId, int quantity, int clientId)
    {
        ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
        var cart = (from x in db.Carts
                      where x.ProductID == productId
                      && x.IsInCart
                      && x.ClientID == clientId
                      select x).FirstOrDefault();

        int oldQuantity = cart.Quantity;
        int newQuantity = oldQuantity + quantity;

        cart.Quantity = newQuantity;
        db.SaveChanges();

        return "Update Successfully!";
    }

    //Mark all the added products as paid, after checkout 
    public void MarkOrderAsPaid(List<Cart> carts)
    {
        ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();

        if(carts != null)
        {
            foreach(Cart cart in carts)
            {
                Cart oldCart = db.Carts.Find(cart.ID);
                oldCart.DataPurchased = DateTime.Now;
                oldCart.IsInCart = false;
            }

        }

        db.SaveChanges();
    }
}