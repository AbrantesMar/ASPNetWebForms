<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="StoreCurso.View.Item.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label ID="lblUserValid" runat="server" />
    </div>
    <input type="hidden" id="lblId" runat="server" />
    <div>
        <asp:Label ID="lblName" runat="server" Text="Nome" CssClass="form-label"></asp:Label>
        <asp:TextBox ID="txtName" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblDescription" CssClass="form-label" runat="server" Text="Descricao" />
        <asp:TextBox ID="txtDescription" CssClass="form-control" runat="server" />
    </div>
    <div>
        <asp:Label ID="lblPrice" runat="server" Text="Preco" />
        <asp:TextBox ID="txtPrice" runat="server" />
    </div>
    <div>
        <asp:Button ID="btnSave" runat="server" Text="Salvar Item" CssClass="btn btn-default" OnClick="btnSave_Click" />
        <asp:Button ID="btnClean" runat="server" Text="Limpar campos" OnClick="btnClean_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Alterar Item" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnLogout" Text="Sair da aplicacao" runat="server" OnClick="btnLogout_Click" />
    </div>
</asp:Content>
