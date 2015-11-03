using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductModel
/// </summary>
public class ProductModel
{
	public string InsertProduct(Product product)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
            db.Products.Add(product);
            db.SaveChanges();

            return product.Name + " was successfully inserted!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateProduct(int id, Product product)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();

            //Fetch object from db
            Product p = db.Products.Find(id);

            p.Name = product.Name;
            p.Price = product.Price;
            p.CategoryID = product.CategoryID;
            p.Description = product.Description;
            p.SupplierID = product.SupplierID;
            p.Image = product.Image;
            p.Color = product.Color;
            db.SaveChanges();
            return product.Name + " was successfully updated!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteProduct(int id)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
            Product product = db.Products.Find(id);

            db.Products.Attach(product);
            db.Products.Remove(product);
            db.SaveChanges();

            return product.Name +  " was successfully deleted!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public Product GetProduct(int id)
    {
        try
        {
            using (ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities())
            {
                Product product = db.Products.Find(id);
                return product;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public List<Product> GetAllProducts()
    {
        try
        {
            using (ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities())
            {
                List<Product> products = (from x in db.Products
                                          select x).ToList();
                return products;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

    public List<Product> GetProductByCategory(int categoryId)
    {
        try
        {
            using (ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities())
            {
                List<Product> products = (from x in db.Products
                                          where x.CategoryID == categoryId
                                          select x).ToList();
                return products;
            }
        }
        catch (Exception)
        {
            return null;
        }
    }

}