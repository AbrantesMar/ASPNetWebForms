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

        public ProductContext()
        {
            //public DbSet<Category> Categories { get; set; }
            


        }
    }
}