using ASPNetWebForms.Model;
using System;

namespace ASPNetWebForms
{
    public partial class AdicionarProdutos : System.Web.UI.Page
    {
        public bool isInsert = true;
        public int? idProdutoUrl;

        protected void Page_Load(object sender, EventArgs e)
        {
            //idProductUrl = urlSession["id"];
        }

        protected void btnEnviarFormulario_Click(object sender, EventArgs e)
        {
            if(isInsert) 
            {
                var product = new Product();
                product.Id = 0;
                product.Name = txtName.Text;
                product.Description = txtDescription.Text;
                ProductContext.ProductsList.Add(product);
            } else
            {
                var idProduct = idProdutoUrl != null ? idProdutoUrl : 0;
                // var product = ProductContext.ProductsList.Find(p => p.Id.Equals(idProdutoUrl));
                var product = ProductContext.ProductsList.Find(p => p.Id.Equals(idProduct));
                product.Id = product.Id ;
                product.Name = txtName.Text;
                product.Description = txtDescription.Text;
                ProductContext.ProductsList.Add(product);
            }

        }
    }
}