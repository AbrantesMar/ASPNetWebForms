using System.Collections.Generic;
using System.Data.Entity;

namespace ASPNetWebForms.Model
{
    public class ProductContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<CartItem> ShoppingCartItems { get; set; }

        public ProductContext() : base("DBTreinamentoEntity")
        {



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