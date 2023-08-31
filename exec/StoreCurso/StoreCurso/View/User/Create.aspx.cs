using StoreCurso.WebControl;
using System;

namespace StoreCurso.View.User
{
    public partial class Create : System.Web.UI.Page
    {
        private string SESSION_USER_LOGIN = "UserLogin";
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSetInfoUserInLbl_Click(object sender, EventArgs e)
        {
            this.lblUserValid.Text = this.loginControl.IsValidLogin ? "Usuario logou com sucesso" : "Usuario nao encontrado";
            if (Session[SESSION_USER_LOGIN] == null)
            {
                this.lblUserValid.Text = "Session nao existe";
                return;
            }
            var session = Session[SESSION_USER_LOGIN];
            this.lblUserValid.Text = (bool)session ? "Usuario logou com sucesso" : "Usuario nao encontrado";
            
        }

        protected void lnkSetUser_Click(object sender, EventArgs e)
        {
            this.lblUserValid.Text = this.loginControl.IsValidLogin ? "Usuario logou com sucesso" : "Usuario nao encontrado";
            if (Session[SESSION_USER_LOGIN] == null)
            {
                this.lblUserValid.Text = "Session nao existe";
                return;
            }
            var session = Session[SESSION_USER_LOGIN];
            this.lblUserValid.Text = (bool)session ? "Usuario logou com sucesso" : "Usuario nao encontrado";

        }

        public void Logout() => Session["UserLogin"] = null;

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}