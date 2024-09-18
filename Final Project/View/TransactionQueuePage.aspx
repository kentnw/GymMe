<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavigationBar.Master" AutoEventWireup="true" CodeBehind="TransactionQueuePage.aspx.cs" Inherits="Final_Project.View.TransactionQueuePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction Queue Page</h1>
    <asp:GridView ID="GridViewTransactionQueue" runat="server" OnRowEditing="GridViewTransactionQueue_RowEditing" OnRowDeleting="GridViewTransactionQueue_RowDeleting">
        <Columns>
            <asp:CommandField ButtonType="Button" EditText="Handle" HeaderText="Actions" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" DeleteText="Detail" ShowDeleteButton="True">
            <ItemStyle HorizontalAlign="Center" />
            </asp:CommandField>
        </Columns>
    </asp:GridView>
    <div>
        <asp:Label ID="LabelInformation" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
