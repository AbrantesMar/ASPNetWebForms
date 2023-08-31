<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="StoreCurso.View.Store.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="lblUserValid" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblName" runat="server" Text="Nome" />
        <asp:TextBox ID="txtName" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblStore" runat="server" Text="Descricao" />
        <asp:TextBox ID="txtStore" runat="server" />
    </div>
    <div>
        <asp:Button ID="btnSave" Text="Salvar" runat="server" OnClick="btnSave_Click" />
        <asp:Button ID="btnLogout" Text="Sair da aplicacao" runat="server" OnClick="btnLogout_Click" />
    </div>
</asp:Content>
