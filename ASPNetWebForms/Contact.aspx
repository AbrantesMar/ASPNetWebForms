<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ASPNetWebForms.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <section>
        <form method="post" action="Contact.aspx" title="Formulario de Cadastro">
            <div>
                <asp:Label ID="lblNomeDaPessoa" runat="server" Text="Nome da pessoa"></asp:Label>
                <br />
                <asp:Label ID="lblNomeServer" runat="server" Text="Nome da pessoa"></asp:Label>
                <asp:TextBox ID="txtNomeDaPessoa" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblDocumento" runat="server" Text="Documento"></asp:Label>
                <br />
                <asp:Label ID="lblDocumentServer" runat="server" Text="Documento servidor"></asp:Label>
                <asp:TextBox ID="txtDocumento" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblIdade" runat="server" Text="Idade"></asp:Label>
                <asp:Calendar ID="dtIdade" runat="server"></asp:Calendar>
            </div>
            <div>
                <asp:Label ID="lblEmail" runat="server" Text="e-mail"></asp:Label>
                <br />
                <asp:Label ID="lblEmailServer" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblSenha" runat="server" Text="senha"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </div>
            <div>
                <label>Telefone</label>
                <asp:Label ID="lblTelefone" runat="server" Text="Telefone"></asp:Label>
                <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            </div>
            <div>
                <asp:Button ID="btnEnviarFormulario" runat="server" Text="Enviar ao servicor" OnClick="btnEnviarFormulario_Click" />
            </div>
        </form>
    </section>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
