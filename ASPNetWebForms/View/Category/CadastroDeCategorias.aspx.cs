using ASPNetWebForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNetWebForms
{
    public partial class CadastroDeCategorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviarFormulario_Click(object sender, EventArgs e)
        {
            var category = new Category();
            category.Id = 6;
            category.Name = txtName.Text;
            category.Description = txtDescription.Text;
            ProductContext.CategoriesList.Add(category);
        }
    }
}