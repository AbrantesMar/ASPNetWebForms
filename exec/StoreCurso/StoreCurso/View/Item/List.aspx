<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="StoreCurso.View.Item.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <label>Nome</label>
        <asp:TextBox ID="txtName" runat="server" />
        <asp:Button ID="btnNameFilter" runat="server" Text="Filtar dados" OnClick="btnNameFilter_Click" />
    </div>
    <div>
        <a href="Create.aspx">Create.aspx</a>
    </div>
    <div>
        <asp:GridView ID="lstItem" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="lstItem_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>

            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White"></FooterStyle>

            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White"></HeaderStyle>

            <PagerStyle HorizontalAlign="Center" BackColor="#FFCC66" ForeColor="#333333"></PagerStyle>

            <RowStyle BackColor="#FFFBD6" ForeColor="#333333"></RowStyle>

            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy"></SelectedRowStyle>

            <SortedAscendingCellStyle BackColor="#FDF5AC"></SortedAscendingCellStyle>

            <SortedAscendingHeaderStyle BackColor="#4D0000"></SortedAscendingHeaderStyle>

            <SortedDescendingCellStyle BackColor="#FCF6C0"></SortedDescendingCellStyle>

            <SortedDescendingHeaderStyle BackColor="#820000"></SortedDescendingHeaderStyle>
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lkbSelectedItem" OnClick="lkbSelectedItem_Click">Selecionar</asp:LinkButton>
                        <asp:LinkButton runat="server" ID="lnkDeletedItem" OnClick="lnkDeletedItem_Click">Deletar</asp:LinkButton>
                        <asp:LinkButton runat="server" ID="lnkUpdateItem" OnClick="lnkUpdateItem_Click">Atualizar</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
