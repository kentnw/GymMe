<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavigationBar.Master" AutoEventWireup="true" CodeBehind="HistoryPage.aspx.cs" Inherits="Final_Project.View.HistoryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>History Page</h1>
    <asp:GridView ID="GridViewHistory" runat="server" OnSelectedIndexChanged="GridViewHistory_SelectedIndexChanged" OnRowEditing="GridViewHistory_RowEditing">
        <Columns>
            <asp:CommandField ButtonType="Button" EditText="Detail" HeaderText="Detail" ShowCancelButton="False" ShowEditButton="True" ShowHeader="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
