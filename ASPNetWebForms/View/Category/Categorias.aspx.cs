using ASPNetWebForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASPNetWebForms
{
    public partial class Categorias : System.Web.UI.Page
    {
        public List<Category> Categories;

        protected void Page_Load(object sender, EventArgs e)
        {
            GridViewCategories.DataSource = GetCategories().ToList();
            GridViewCategories.DataBind();

        }

        public IQueryable<Category> GetCategories()
         {
            var _db = new ProductContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        
        }

        protected void GridViewCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("selecionou o item: " + sender.ToString());
        }

        protected void GridViewCategories_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if(e.CommandName == "EditButton")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                var row = GridViewCategories.Rows[index];
                Response.Redirect("~/Create.aspx?CategoryId=" + row.Cells[0].Text);
            }

        }
    }
}