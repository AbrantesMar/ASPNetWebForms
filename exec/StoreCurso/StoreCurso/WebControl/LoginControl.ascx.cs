using StoreCurso.Model;
using System;

namespace StoreCurso.WebControl
{
    public partial class LoginControl : System.Web.UI.UserControl
    {
        public User User { get; set; }
        public bool IsValidLogin { get; set; }
        private string SESSION_USER_LOGIN = "UserLogin";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (User == null)
                {
                    User = new User(0, "Testando");
                }
            }

        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            if (User == null)
            {
                User = new User();
                User.Login = this.txtLogin.Text;
                User.Password = this.txtPassword.Text;

            } else
            {
                User.Login = this.txtLogin.Text;
                User.Password = this.txtPassword.Text;
            }

            var validateUser = "marcio" == User.Login && "123456".Equals(User.Password);
            IsValidLogin = "marcio" == User.Login && "123456".Equals(User.Password) ? true : false;

            if (validateUser)
            {
                Console.WriteLine("Usuario logado com sucesso!");
                IsValidLogin = true;
                Session[SESSION_USER_LOGIN] = true;
            } else if (!validateUser || IsPostBack)
            {
                Console.WriteLine("Usuario nao encontrado!");
                IsValidLogin = false;
                Session[SESSION_USER_LOGIN] = false;
            }

        }

        protected void btnCleanAllInputs_Click(object sender, EventArgs e)
        {
            this.txtLogin.Text = string.Empty;
            this.txtPassword.Text = string.Empty;
            CleanUser();
        }

        protected void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            User = new User()
            {
                Password = this.txtPassword.Text,
                Email = this.txtEmail.Text,
                Login = this.txtLogin.Text,
                Valid = true,
            };
        }

        private void CleanUser()
        {
            User = null;
        }

        public void AlertLoginApplication()
        {
            Response.Write("<script>alert('Realize o login na sua aplicacao')</script>");
            return;
        }
    }
}