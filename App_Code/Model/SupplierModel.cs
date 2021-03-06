﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SupplierModel
/// </summary>
public class SupplierModel
{
    public string InsertSupplier(Supplier supplier)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
            db.Suppliers.Add(supplier);
            db.SaveChanges();

            return supplier.Name + " was successfully inserted!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string UpdateSupplier(int id, Supplier supplier)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();

            //Fetch object from db
            Supplier p = db.Suppliers.Find(id);

            p.Name = supplier.Name;
            p.PhoneNumber = supplier.PhoneNumber;
            p.EmailAddress = supplier.EmailAddress;

            db.SaveChanges();
            return supplier.Name + " was successfully updated!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }

    public string DeleteSupplier(int id)
    {
        try
        {
            ZHUW15sqlserver1Entities db = new ZHUW15sqlserver1Entities();
            Supplier supplier = db.Suppliers.Find(id);

            db.Suppliers.Attach(supplier);
            db.Suppliers.Remove(supplier);
            db.SaveChanges();

            return supplier.Name + " was successfully delected!";
        }
        catch (Exception e)
        {
            return "Error:" + e;
        }
    }
}