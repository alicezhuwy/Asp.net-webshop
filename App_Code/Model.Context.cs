﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class ZHUW15sqlserver1Entities : DbContext
{
    public ZHUW15sqlserver1Entities()
        : base("name=ZHUW15sqlserver1Entities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Cart> Carts { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<Product> Products { get; set; }
    public virtual DbSet<Supplier> Suppliers { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
}
