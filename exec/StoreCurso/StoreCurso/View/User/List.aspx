<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="StoreCurso.View.User.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <label>Nome</label>
        <asp:TextBox ID="txtName" runat="server" />
        <asp:Button ID="btnNameFilter" runat="server" Text="Filtar" OnClick="btnNameFilter_Click" />
    </div>
    <div>
        <a href="Create.aspx">Create.aspx</a>
    </div>
    <asp:GridView ID="lstUsers" runat="server" OnSelectedIndexChanged="lstUsers_SelectedIndexChanged"></asp:GridView>
</asp:Content>
