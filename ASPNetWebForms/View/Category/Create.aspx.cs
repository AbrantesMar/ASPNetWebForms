using System;
using System.Collections.Generic;
using ASPNetWebForms.Model;

namespace ASPNetWebForms.View.Category
{
    public partial class Create : System.Web.UI.Page
    {
        public List<Model.Category> Categories { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            var categoryIdUrl = Request.QueryString["CategoryId"];
            var productIdUrl = Request.QueryString["ProductId"];
            if (categoryIdUrl != null && productIdUrl != null)
            {
                var categoryId = Int32.Parse(categoryIdUrl);
                var productId = Int32.Parse(productIdUrl);
                var category = GetCategory(categoryId);
                if (category != null)
                {
                    txtName.Text = category.Name;
                    txtDescription.Text = category.Description;
                }

            }


        }

        protected void btnEnviarFormulario_Click(object sender, EventArgs e)
        {
            if (Categories == null)
            {
                Categories = ProductContext.MakeCategoriesList();
            }
            else
            {
                if (Categories.Count <= 0)
                    Categories = ProductContext.MakeCategoriesList();
            }

            var category = new Model.Category();
            category.Id = Categories.Count + 1;
            category.Name = txtName.Text;
            category.Description = txtDescription.Text;
            Categories.Add(category);
        }

        public Model.Category GetCategory(int categoryId)
        {
            var category = ProductContext.MakeCategoriesList().Find(c => c.Id == categoryId);
            return category;
        }
    }
}