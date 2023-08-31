<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="ASPNetWebForms.View.Category.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="divNome">
        <asp:Label ID="lblName" runat="server" Text="Nome"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </div>
    <div id="divLblDescription">
        <asp:Label ID="lblDescription" runat="server" Text="Descrição"></asp:Label>
        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
    </div>
    <a id="btnSalvar">Lista de Categorias</a>
    <div id="listaOrdenada">
      <ul>
        <li>Teste</li>
      </ul>
    </div>

    <link href="../../Content/style.css" rel="stylesheet" />
    <script src="../../Scripts/AulaJs.js"></script>
    
</asp:Content>
