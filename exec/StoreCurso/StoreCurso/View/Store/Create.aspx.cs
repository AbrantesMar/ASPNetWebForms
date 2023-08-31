using System;
using StoreCurso.Model;

namespace StoreCurso.View.Store
{
    public partial class Create : System.Web.UI.Page
    {
        public Model.Store Store { get; set; }
        private string SESSION_USER_LOGIN = "UserLogin";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[SESSION_USER_LOGIN] == null)
            {
                this.lblUserValid.Text = "Session nao existe";
                return;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Store = new Model.Store
            {
                Id = BaseModels.Stores.Count + 1,
                Name = txtName.Text,
                Description = txtStore.Text,
                Valid = true,
                CreationDate = DateTime.Now,
            };

            BaseModels.CreateStore(Store);
            Response.Redirect("List.aspx");
        }

        public void Logout() => Session["UserLogin"] = null;

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}