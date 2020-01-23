using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
//context class for data access
namespace ACMEINC.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("ACMEINC")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }//allows the update/edit/etc of cart using the cartitem model for managment
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails
        {
            get; set;
        }
    }
}