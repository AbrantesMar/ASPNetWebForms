using ASPNetWebForms.Model;
using System;
using System.Collections.Generic;

namespace ASPNetWebForms
{
    public partial class Categorias : System.Web.UI.Page
    {
        public List<Category> Categories;

        protected void Page_Load(object sender, EventArgs e)
        {
            Categories = ProductContext.MakeCategoriesList();
            Categories.Add(new Category
            {
                Id = 4,
                Description = "PC",
                Name = "PC mobile"
            });
            GridViewCategories.DataSource = Categories;

        }
    }
}