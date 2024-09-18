using Final_Project.Controller;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null && Request.Cookies["user_cookie"] != null)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
        }

        protected void LinkButtonRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/RegisterPage.aspx");
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;
            bool rememberme = CheckBoxRememberMe.Checked;

            LabelInformation.Text = UserController.ValidateUserLogin(username, password);
            if (LabelInformation.Text == "Login Success!")
            {
                if (rememberme == true)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = username;
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);

                }

                HttpCookie userid = new HttpCookie("userid_cookie");
                userid.Value = UserRepository.GetUserID(username);
                Response.Cookies.Add(userid);

                HttpCookie userrole = new HttpCookie("userrole_cookie");
                userrole.Value = UserRepository.GetUserRole(username);
                Response.Cookies.Add(userrole);

                Session["user"] = username;
                Response.Redirect("~/View/HomePage.aspx");
                
            }
        }
    }
}