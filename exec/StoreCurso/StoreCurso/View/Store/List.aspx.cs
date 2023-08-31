using System;
using System.Collections.Generic;
using System.Web.UI;

namespace StoreCurso.View.Store
{
    public partial class List : Page
    {
        public List<Model.Store> Stores { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Model.BaseModels.Stores == null)
                Model.BaseModels.GetStores();

            lstStore.DataSource = Model.BaseModels.Stores;
            lstStore.DataBind();
        }

        protected void btnNameFilter_Click(object sender, EventArgs e)
        {

        }
    }
}