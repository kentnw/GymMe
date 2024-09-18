<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavigationBar.Master" AutoEventWireup="true" CodeBehind="OrderSupplement.aspx.cs" Inherits="Final_Project.View.OrderSupplement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Order Supplement</h1>
    <asp:GridView ID="GridViewOrderSupplement" runat="server" BorderColor="Black" BorderStyle="Solid" CellPadding="4" ForeColor="#333333" OnSelectedIndexChanged="GridViewOrderSupplement_SelectedIndexChanged" OnRowDeleting="GridViewOrderSupplement_RowDeleting">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:TemplateField HeaderText="Quantity">
                <ItemTemplate>
                    <asp:TextBox ID="TextBoxQuantity" runat="server"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ButtonType="Button" HeaderText="Order" ShowCancelButton="False" ShowHeader="True" EditText="Order" ShowDeleteButton="True" DeleteText="Order" />
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
    <asp:GridView ID="GridViewCart" runat="server"></asp:GridView>
    <div>
        <asp:Label ID="LabelCartInformation" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Button ID="ButtonClearCart" runat="server" Text="Clear Cart" OnClick="ButtonClearCart_Click"/>
        <asp:Button ID="ButtonCheckout" runat="server" Text="Checkout" OnClick="ButtonCheckout_Click"/>
    </div>
</asp:Content>
