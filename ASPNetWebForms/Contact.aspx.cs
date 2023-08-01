using ASPNetWebForms.Model;
using System;
using System.Web.UI;

namespace ASPNetWebForms
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviarFormulario_Click(object sender, EventArgs e)
        {
            var person = new Person();
            person.Name = txtNomeDaPessoa.Text;
            lblNomeServer.Text = person.Name;
            person.Document = txtDocumento.Text;
            lblDocumentServer.Text = person.Document;
            person.Email = txtEmail.Text;
            lblEmailServer.Text = person.Email;

            lblDocumento.Text = txtNomeDaPessoa.Text;
        }
    }
}