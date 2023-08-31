<%@ Page Title="Categorias" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="ASPNetWebForms.Categorias" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:GridView ID="GridViewCategories"
            runat="server"
            AutoGenerateColumns="true"
            ItemType="ASPNetWebForms.Model.Category"
            OnSelectedIndexChanged="GridViewCategories_SelectedIndexChanged"
            OnRowCommand="GridViewCategories_RowCommand">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnEditar" runat="server" Width="60" Text="Editar"
                            CommandName="EditButton" CommandArgument="<%((GridViewRow) Container).RowIndex %>" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <a href="Create.aspx">Cadastro De Categorias</a>
        <input type="button" onclick="creatAlert()" value="Criar alerta" />
        <button title="Alerta Java Script" onclick="creatAlert()">Alert</button>
        <script type="text/javascript">
            function creatAlert()
            {
                alert("Java Script no codigo")
            }



        </script>

    </div>
</asp:Content>
