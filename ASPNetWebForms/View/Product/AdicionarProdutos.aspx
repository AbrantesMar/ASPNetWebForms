<%@ Page Title="Adicionar Produtos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdicionarProdutos.aspx.cs" Inherits="ASPNetWebForms.AdicionarProdutos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form method="post" action="AdicionarProdutos.aspx" title="Formulario de cadastro de produtos">
        <div>
            <asp:Label ID="lblName" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblDescription" runat="server" Text="Descrição"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblImagePath" runat="server" Text="Selecione uma imagem"></asp:Label>
            <input id="fileImagePath" type="file" />
        </div>
        <asp:Button ID="btnSave" runat="server" Text="Salvar Categorias" OnClick="btnEnviarFormulario_Click" />
    </form>
</asp:Content>
