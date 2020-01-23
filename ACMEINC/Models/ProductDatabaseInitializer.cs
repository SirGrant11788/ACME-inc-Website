using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ACMEINC.Models
{
    //note. removed : DropCreateDatabaseIfModelChanges<ProductContext>
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        //static string con = ConfigurationManager.ConnectionStrings[@"Data Source=GRANT-PC\SQLEXPRESS;Initial Catalog=ACME;Integrated Security=True"].ToString();
        //note. removed override
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
new Category
{
CategoryID = 1,
CategoryName = "Electronics"
},
new Category
{
CategoryID = 2,
CategoryName = "Computers"
},
new Category
{
CategoryID = 3,
CategoryName = "Keyboard and Mouse"
},
new Category
{
CategoryID = 4,
CategoryName = "Monitors"
},
new Category
{
CategoryID = 5,
CategoryName = "Cables"
},
};
            return categories;
        }

        //private static List<Category> GetCategories()
        //{

        //    var categories = new List<Category>();

        //    using (SqlConnection connection = new SqlConnection(con))
        //    {
        //        connection.Open();
        //        string query = "SELECT * FROM PRODUCTS";
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    new Category
        //                    {
        //                        CategoryID = int.Parse(reader["categoryID"].ToString()),
        //                        CategoryName = reader["category"].ToString()
        //                    };

        //                }
        //            }
        //        }
        //    }
        //    return categories;
        //}
        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Resistor",
                    Description = "12Ohm Risistor!",
                    ImagePath="resistor.png",
                    UnitPrice = 22.50,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Heat Sink",
                    Description = "Cools componets.",
                    ImagePath="heatsink.jpg",
                    UnitPrice = 15.95,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Fuse",
                    Description = "3v 12amp",
                    ImagePath="fuse.png",
                    UnitPrice = 32.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Breaker",
                    Description = "120v 30amps 60ohms",
                    ImagePath="breaker.jpg",
                    UnitPrice = 89.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Elictric motor",
                    Description = "small dc motor for projects. 30rpm.",
                    ImagePath="motor.jpg",
                    UnitPrice = 34.95,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Acer Delux",
                    Description = "Office PC",
                    ImagePath="delux.jpg",
                    UnitPrice = 935.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Acer Predator",
                    Description = "Gaming Laptop",
                    ImagePath="predator.jpg",
                    UnitPrice = 9434.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Dell OfficeQueen",
                    Description = "For day to day office work",
                    ImagePath="officequeen.jpg",
                    UnitPrice = 2123.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Gaming Titan",
                    Description = "for ultimate gaming exp",
                    ImagePath="titan.png",
                    UnitPrice = 9132.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Corsair Basic Keyboard",
                    Description = "prefect for the office. very quite",
                    ImagePath="basickeyboard.jpg",
                    UnitPrice = 151.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Corsair Basic Mouse",
                    Description = "Quite offcie mouse",
                    ImagePath="mouse.jpg",
                    UnitPrice = 126.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Corsair gaming mx",
                    Description = "Mechanical gaming keyboard with macros",
                    ImagePath="gamingmx.jpg",
                    UnitPrice = 229.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Dell HD GHU798",
                    Description = "HD 1080 23inch",
                    ImagePath="dellhd.jpg",
                    UnitPrice = 915.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Dell 4k yhuiyi67896",
                    Description = "4k 27inch",
                    ImagePath="dell4k.jpg",
                    UnitPrice = 411.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Dell Gaming 4k",
                    Description = "60HZ RGB 4k 27inch gaming monitor!",
                    ImagePath="dell4kgaming.jpg",
                    UnitPrice = 4992.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "USB A to C",
                    Description = "USB 3.0 usb A to usb C connection type",
                    ImagePath="usbatoc.jpg",
                    UnitPrice = 122.95,
                    CategoryID = 5
                }
            };

            return products;
        }




        //private static List<Product> GetProducts()
        //{
        //    var products = new List<Product>();

        //    using (SqlConnection connection = new SqlConnection(con))
        //    {
        //        connection.Open();
        //        string query = "SELECT * FROM PRODUCTS";
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    new Product
        //                    {

        //                        ProductID = int.Parse(reader["PID"].ToString()),
        //                        ProductName = reader["name"].ToString(),
        //                        Description = reader["description"].ToString(),
        //                        ImagePath = reader["BLOBData"].ToString(),//note. to fix in db or this here
        //                        UnitPrice = int.Parse(reader["price"].ToString()),
        //                        CategoryID = int.Parse(reader["categoryID"].ToString()),
        //                    };

        //                }
        //            }
        //        }
        //    }



        //    return products;
        //}

    }


}