using Final_Project.Controller;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project.View
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButtonLoginHere_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string email = TextBoxEmail.Text;
            string gender = "";
            string password = TextBoxPassword.Text;
            string confirmpassword = TextBoxConfirmationPassword.Text;
            //string tempDOB = TextBoxDateOfBirth.Text;
            DateTime DOB = CalendarDateOfBirth.SelectedDate;
            if (RadioButtonFemale.Checked == true)
            {
                gender = RadioButtonFemale.Text;
            }
            else if(RadioButtonMale.Checked == true)
            {
                gender = RadioButtonMale.Text;
            }
            LabelInformation.Text = UserController.ValidateNewUser(username, email, gender, password, confirmpassword, DOB);
            if(LabelInformation.Text == "Registration Success!")
            {
                LabelInformation.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                LabelInformation.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}