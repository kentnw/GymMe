<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavigationBar.Master" AutoEventWireup="true" CodeBehind="ManageSupplement.aspx.cs" Inherits="Final_Project.View.Manage_Supplement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Manage Supplement</h1>
    <asp:GridView ID="GridViewManageSupplement" runat="server" OnSelectedIndexChanged="GridViewManageSupplement_SelectedIndexChanged" OnRowDeleting="GridViewManageSupplement_RowDeleting" OnRowEditing="GridViewManageSupplement_RowEditing" BorderColor="Black" BorderStyle="Solid" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ButtonType="Button" HeaderText="Action" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" EditText="Update" />
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    <asp:Label ID="LabelInformation" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <asp:Button ID="ButtonInsertSupplement" runat="server" Text="Insert Supplement" OnClick="ButtonInsertSupplement_Click"/>
</asp:Content>
