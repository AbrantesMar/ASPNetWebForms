using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetWebForms.Model
{
    public class ProductContext //: DbContext
    {
        public Category Categories { get; set; }
        public Product Products { get; set; }
        public CartItem ShoppingCartItems { get; set; }

        public static List<Product> ProductsList { get; set; }
        public static List<Category> CategoriesList { get; set; }

        public ProductContext()
        {
            //public DbSet<Category> Categories { get; set; }
            


        }

        public static List<Category> MakeCategoriesList()
        {
            var products = MakeProducts();
            var categories = new List<Category> 
            { 
                new Category 
                {
                    Id = 1,
                    Name = "Eletronico",
                    Description = "Todos eletronicos",
                    Products = new List<Product> {
                        products[1]
                    }
                },
                new Category 
                {
                    Id = 2,
                    Name = "Carros",
                    Description = "Todos eletronicos",
                    Products = products
                },
                new Category 
                {
                    Id = 3,
                    Name = "Computadores",
                    Description = "Todos eletronicos",
                    Products = new List<Product> {
                        products[1],
                        products[0]
                    }
                }
            };

            return categories;
        }

        public static List<Product> MakeProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Description = "Headset",
                    ImagePath = "",
                    Name = "Headset",
                    UnitPrice = 50.4
                },
                new Product
                {
                    Id = 2,
                    Description = "Teclado",
                    ImagePath = "",
                    Name = "Teclado",
                    UnitPrice = 22.4
                },
                new Product
                {
                    Id = 3,
                    Description = "Agile",
                    ImagePath = "",
                    Name = "",
                    UnitPrice = 22.4
                }
            };

            return products;
        }
    }
}