using System;
using System.Web.UI;
using StoreCurso.Model;


namespace StoreCurso.View.Item
{
    public partial class Create : System.Web.UI.Page
    {
        private string SESSION_USER_LOGIN = "UserLogin";
        private Model.Item ItemSelected;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[SESSION_USER_LOGIN] == null)
            {
                this.lblUserValid.Text = "Session nao existe";
                //return;
            }
            var queryParam = Request.QueryString["itemId"];
            if (queryParam != null)
            {
                int itemId = 0;
                if(!String.IsNullOrEmpty(queryParam) && int.TryParse(queryParam, out itemId))
                {
                    if (BaseModels.Items == null)
                    {
                        Response.Redirect("List.aspx");
                        return;
                    }
                        
                    ItemSelected = BaseModels.Items.Find(i => i.Id == itemId);
                    txtDescription.Text = ItemSelected.Description;
                    txtName.Text = ItemSelected.Name;
                    txtPrice.Text = ItemSelected.Price.ToString("00,00");
                    lblId.Value = ItemSelected.Id.ToString();
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Model.BaseModels.Items == null)
                Response.Redirect("List.aspx");
            Decimal price = 0;
            try
            {
                var priceValidation = txtPrice.Text.Contains("[a-zA-Z]");
                price = Convert.ToDecimal(txtPrice.Text);
                var item = new Model.Item
                {
                    Id = Model.BaseModels.Items.Count + 1,
                    Description = txtDescription.Text,
                    Name = txtName.Text,
                    Price = price
                };

                BaseModels.Items.Add(item);
                Response.Redirect("List.aspx");
            }
            catch (Exception ex)
            {
                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "Valor do preco esta incorreto", true);
                Response.Write("<script>alert('Valor do preco esta incorreto: \\n" + ex.Message + "')</script>");
                return;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void btnClean_Click(object sender, EventArgs e)
        {
            this.txtName.Text = string.Empty;
            this.txtPrice.Text = string.Empty;
            this.txtDescription.Text = string.Empty;
        }
        public void Logout() => Session["UserLogin"] = null;

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}