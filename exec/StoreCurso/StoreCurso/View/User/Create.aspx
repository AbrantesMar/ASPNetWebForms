<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="StoreCurso.View.User.Create" %>
<%@ Register Src="~/WebControl/LoginControl.ascx" TagPrefix="login" TagName="LoginControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <login:LoginControl runat="server" id="loginControl" />
    <div style="background-color: bisque;">
        <asp:Label ID="lblUserValid" runat="server" Text="Usuario esta logado?"></asp:Label>
        <asp:Button ID="btnSetInfoUserInLbl" runat="server" Text="Passar usuario para o lbl" OnClick="btnSetInfoUserInLbl_Click" />
        <asp:LinkButton ID="lnkSetUser" runat="server" Text="Valor sem atualizar" OnClick="lnkSetUser_Click" />
        <asp:Button ID="btnLogout" Text="Sair da aplicacao" runat="server" OnClick="btnLogout_Click" />
    </div>
</asp:Content>
