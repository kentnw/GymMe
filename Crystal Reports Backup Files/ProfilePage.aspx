<%@ Page Title="" Language="C#" MasterPageFile="~/Master/NavigationBar.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="Final_Project.View.ProfilePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Profile Page</h1>
    <div>
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
            <asp:RadioButton ID="RadioButtonMale" runat="server" Text="Male" GroupName="Gender" />
            <asp:RadioButton ID="RadioButtonFemale" runat="server" Text="Female" GroupName="Gender" />
        </div>
        <div>
            <asp:Label ID="LabelDateOfBirth" runat="server" Text="Date of Birth: "></asp:Label>
            <asp:Calendar ID="CalendarDateOfBirth" runat="server"></asp:Calendar>
        </div>
         <div>
     <asp:Label ID="LabelInformationProfile" runat="server" Text="" ForeColor="Red"></asp:Label>
 </div>
        <div>
            <asp:Button ID="ButtonUpdateProfile" runat="server" Text="Update Profile" OnClick="ButtonUpdateProfile_Click" />
        </div>
    </div>
    <br />
    <br />
    <div>
        <div>
            <asp:Label ID="LabelNewPassword" runat="server" Text="Current Password: "></asp:Label>
            <asp:TextBox ID="TextBoxCurrentPassword" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelPassword" runat="server" Text="New Password: "></asp:Label>
            <asp:TextBox ID="TextBoxNewPassword" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="LabelConfirmationPassword" runat="server" Text="Confirmation Password: "></asp:Label>
            <asp:TextBox ID="TextBoxNewConfirmationPassword" runat="server"></asp:TextBox>
        </div>
    </div>

    <div>
        <asp:Label ID="LabelInformationPassword" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Button ID="ButtonUpdatePassword" runat="server" Text="Update Password" OnClick="ButtonUpdatePassword_Click" />
    </div>
</asp:Content>
