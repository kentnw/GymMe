<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Final_Project.View.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Register Page</h1>
        <div>
            <asp:Label ID="LabelUsername" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelEmail" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelGender" runat="server" Text="Gender: "></asp:Label>
            <asp:RadioButton ID="RadioButtonMale" runat="server" text="Male" GroupName="Gender"/>
            <asp:RadioButton ID="RadioButtonFemale" runat="server" text="Female" GroupName="Gender"/>
        </div>
        <div>
            <asp:Label ID="LabelPassword" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelConfirmationPassword" runat="server" Text="Confirmation Password: "></asp:Label>
            <asp:TextBox ID="TextBoxConfirmationPassword" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelDateOfBirth" runat="server" Text="Date of Birth: "></asp:Label>
            <%--<asp:TextBox ID="TextBoxDateOfBirth" runat="server" TextMode="Date"></asp:TextBox>--%>
            <asp:calendar id="CalendarDateOfBirth" runat="server"></asp:calendar>
        </div>
        <div>
            <asp:Label ID="LabelInformation" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
        <div>
            <asp:Button ID="ButtonRegister" runat="server" Text="Register" OnClick="ButtonRegister_Click"/>
        </div>
        <div>
            <asp:Label ID="LabelLoginHere" runat="server" Text="Already have an account? "></asp:Label>
            <asp:LinkButton ID="LinkButtonLoginHere" runat="server" OnClick="LinkButtonLoginHere_Click">Login Here</asp:LinkButton>
        </div>
    </form>
</body>
</html>
