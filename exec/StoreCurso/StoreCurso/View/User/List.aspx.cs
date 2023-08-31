using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreCurso.View.User
{
    public partial class List : System.Web.UI.Page
    {
        public List<Model.User> Users { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Model.BaseModels.Users == null)
                Model.BaseModels.GetUsers();

            lstUsers.DataSource = Model.BaseModels.Users;
            lstUsers.DataBind();

        }

        protected void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}