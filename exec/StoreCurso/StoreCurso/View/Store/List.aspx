<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="StoreCurso.View.Store.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <label>Nome</label>
        <asp:TextBox ID="txtName" runat="server" />
        <asp:Button ID="btnNameFilter" runat="server" Text="Filtar" OnClick="btnNameFilter_Click" />
    </div>
    <div>
        <a href="Create.aspx">Create.aspx</a>
    </div>
    <asp:GridView ID="lstStore" runat="server">
    </asp:GridView>
</asp:Content>
