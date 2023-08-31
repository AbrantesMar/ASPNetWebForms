<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="StoreCurso.WebControl.LoginControl" %>
<div>
    <div>
        <asp:Label ID="lblLogin" runat="server" Text="Informe seu usuario"></asp:Label>
        <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lbl" runat="server" Text="Informe seu e-mail"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="lblPassword" runat="server" Text="Informe sua senha"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    </div>
    <asp:Button ID="btnLogar" runat="server" Text="Login" OnClick="btnLogar_Click" />
    <asp:Button ID="btnCleanAllInputs" runat="server" Text="Limpar Campos" OnClick="btnCleanAllInputs_Click" />
    <asp:Button ID="btnCreateNewUser" runat="server" Text="Criar novo usuario" OnClick="btnCreateNewUser_Click" />
</div>