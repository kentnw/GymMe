using Final_Project.Controller;
using Final_Project.Model;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project.View
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }
            HttpCookie userinfo = Request.Cookies["userid_cookie"];
            int userID = Convert.ToInt32(userinfo.Value);
            
            if (!IsPostBack)
            {

                MsUser user = UserRepository.GetUserProfile(userID);
                String username = user.UserName;
                String email = user.UserEmail;
                String genderString = user.UserGender;
                DateTime DateOfBirth = user.UserDOB;
                
                TextBoxUsername.Text = username;
                TextBoxEmail.Text = email;
                if (genderString == "Female")
                {
                    RadioButtonFemale.Checked = true;
                }
                else if (genderString == "Male")
                {
                    RadioButtonMale.Checked = true;
                }
                CalendarDateOfBirth.SelectedDate = DateOfBirth;

            }
        }

        protected void ButtonUpdateProfile_Click(object sender, EventArgs e)
        {
            HttpCookie userinfo = Request.Cookies["userid_cookie"];
            int userID = Convert.ToInt32(userinfo.Value);
            int id = userID;
            String username = TextBoxUsername.Text;
            String email = TextBoxEmail.Text;
            String gender = "";
            if (RadioButtonFemale.Checked == true)
            {
                gender = RadioButtonFemale.Text;
            }
            else if (RadioButtonMale.Checked == true)
            {
                gender = RadioButtonMale.Text;
            }
            DateTime DOB = CalendarDateOfBirth.SelectedDate;
            LabelInformationProfile.Text = UserController.ValidateUpdateUser(id, username, email, gender, DOB);
            if(LabelInformationProfile.Text == "Update Profile Successful!")
            {
                LabelInformationProfile.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                LabelInformationProfile.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void ButtonUpdatePassword_Click(object sender, EventArgs e)
        {
            HttpCookie userinfo = Request.Cookies["userid_cookie"];
            int userID = Convert.ToInt32(userinfo.Value);
            int id = userID;

            String currentpassword = TextBoxCurrentPassword.Text;
            String newpassword = TextBoxNewPassword.Text;
            String confirmpassword = TextBoxNewConfirmationPassword.Text;

            LabelInformationPassword.Text = UserController.ValidateUpdatePassword(id, currentpassword, newpassword, confirmpassword);

            if (LabelInformationPassword.Text == "Update Password Successful!")
            {
                LabelInformationPassword.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                LabelInformationProfile.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}