<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Final_Project.View.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Login Page</h1>
        <div>
            <asp:Label ID="LabelUsername" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelPassword" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="CheckBoxRememberMe" runat="server" text="Remember Me"/>
        </div>
        <div>
            <asp:Label ID="LabelInformation" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
        <div>
            <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" />
        </div>
        <div>
            <asp:Label ID="LabelButtonRegister" runat="server" Text="LinkButtonRegister_Click">Don't Have an Account? </asp:Label>
            <asp:LinkButton ID="LinkButtonRegister" runat="server" OnClick="LinkButtonRegister_Click">Register Here</asp:LinkButton>  
        </div>
    </form>
</body>
</html>
