using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreCurso.View.Item
{
    public partial class List : Page
    {
        public List<Model.Item> Item { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Model.BaseModels.Items == null)
            {
                Model.BaseModels.GetItems();
                Item = new List<Model.Item>();
            }

            lstItem.DataSource = Model.BaseModels.Items;
            lstItem.DataBind();
        }

        protected void btnNameFilter_Click(object sender, EventArgs e)
        {
            Item = Model.BaseModels.Items.FindAll(i => i.Name.Contains(txtName.Text));
            lstItem.DataSource = null;
            lstItem.DataSource = Item;
            lstItem.DataBind();
        }

        protected void lstItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemSelected = (Model.Item)sender;
            var urlWithParam = "Item/Create.aspx?itemId=" + itemSelected.Id;
            Response.Redirect(urlWithParam);
        }

        protected void lkbSelectedItem_Click(object sender, EventArgs e)
        {
            //var control = ((GridViewRow)sender).RowIndex;
            int rowId = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            var itemSelected = lstItem.Rows[rowId].Cells[3].Text;
        }

        protected void lnkDeletedItem_Click(object sender, EventArgs e)
        {
            int rowId = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            int itemSelected = Convert.ToInt32(lstItem.Rows[rowId].Cells[3].Text);
            Model.BaseModels.Items.RemoveAt(itemSelected);
            lstItem.DataSource = Model.BaseModels.Items;
            lstItem.DataBind();
        }

        protected void lnkUpdateItem_Click(object sender, EventArgs e)
        {
            int rowId = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;
            int itemSelected = Convert.ToInt32(lstItem.Rows[rowId].Cells[3].Text);
            var urlWithParam = "Create.aspx?itemId=" + itemSelected;
            Response.Redirect(urlWithParam);
        }
    }
}