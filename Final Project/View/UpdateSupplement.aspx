<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavigationBar.Master" AutoEventWireup="true" CodeBehind="UpdateSupplement.aspx.cs" Inherits="Final_Project.View.UpdateSupplement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Update Supplement</h1>
    <div>
        <asp:Label ID="Label0" runat="server" Text="Currently Editing Supplement With ID: "></asp:Label>
        <asp:Label ID="LabelID" runat="server" Text="" ForeColor="Green"></asp:Label>
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="TextBoxSupplementName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Expiry Date: "></asp:Label>
        <asp:Calendar ID="CalendarExpiryDate" runat="server"></asp:Calendar>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Price: "></asp:Label>
        <asp:TextBox ID="TextBoxSupplementPrice" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label4" runat="server" Text="Type: "></asp:Label>
        <asp:DropDownList ID="DropDownSupplementType" runat="server"></asp:DropDownList>
    </div>
    <div>
        <asp:Label ID="LabelInformation" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Button ID="ButtonUpdateSupplement" runat="server" Text="Update" OnClick="ButtonUpdateSupplement_Click"/>
    </div>

</asp:Content>
