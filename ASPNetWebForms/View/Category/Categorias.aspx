<%@ Page Title="Categorias" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="ASPNetWebForms.Categorias" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:GridView ID="GridViewCategories" runat="server"
            DataSource="Categories" SelectedIndex="">
        </asp:GridView>
    </div>
</asp:Content>
