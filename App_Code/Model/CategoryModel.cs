using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CategoryModel
/// </summary>
public class CategoryModel
{

    public string InsertCategory(Category category)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
            db.Categories.Add(category);
            db.SaveChanges();

            return category.Name + " was successfully inserted!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateCategory(int id, Category category)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();

            //Fetch object from db
            Category p = db.Categories.Find(id);

            p.Name = category.Name;
            p.Description = category.Description;
        
            db.SaveChanges();
            return category.Name + " was successfully updated!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteCategory(int id)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
            Category category = db.Categories.Find(id);

            db.Categories.Attach(category);
            db.Categories.Remove(category);
            db.SaveChanges();

            return category.Name + " was successfully deleted!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
}