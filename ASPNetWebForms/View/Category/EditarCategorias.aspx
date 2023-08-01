<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarCategorias.aspx.cs" Inherits="ASPNetWebForms.EditarCategorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form method="post" action="">
        <div>
            <asp:Label ID="lblName" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblDescription" runat="server" Text="Descrição"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btnSave" runat="server">Salvar Categorias</asp:Button>
    </form>
</asp:Content>
