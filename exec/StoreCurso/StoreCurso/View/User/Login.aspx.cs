using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreCurso.View.User
{
    public partial class Login : System.Web.UI.Page
    {
        private string SESSION_USER_LOGIN = "UserLogin";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[SESSION_USER_LOGIN] == null)
            {
                this.loginControl.AlertLoginApplication();
            }
        }

        public void Logout() => Session["UserLogin"] = null;
    }
}