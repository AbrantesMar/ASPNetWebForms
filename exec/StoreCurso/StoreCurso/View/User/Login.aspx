<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StoreCurso.View.User.Login" %>
<%@ Register Src="~/WebControl/LoginControl.ascx" TagPrefix="login" TagName="LoginControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <login:LoginControl runat="server" id="loginControl" />
</asp:Content>
