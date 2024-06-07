using ExampleGridProduct.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExampleGridProduct.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=DbConnection")
        {

        }

        public DbSet<Product> Products { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //Fluent Api mean validation on server side in entity framework
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}