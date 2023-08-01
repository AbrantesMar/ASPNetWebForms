<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroDeCategorias.aspx.cs" Inherits="ASPNetWebForms.CadastroDeCategorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form method="post" action="CadastroDeCategorias.aspx">
        <div>
            <asp:Label ID="lblName" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblDescription" runat="server" Text="Descrição"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btnSave" runat="server" Text="Salvar Categoria" />
    </form>
</asp:Content>
