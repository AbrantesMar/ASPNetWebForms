using ASPNetWebForms.Model;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace ASPNetWebForms
{
    public partial class ListarProdutos : Page
    {
        public List<Product> Products;
        protected void Page_Load(object sender, EventArgs e)
        {
            //Products = ProductContext.ProductsList;
            //grdProducts.DataSource = Products;
        }
    }
}