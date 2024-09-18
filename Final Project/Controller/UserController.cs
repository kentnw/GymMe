using Final_Project.Handler;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Controller
{
    public class UserController
    {
        public static String ValidateNewUser(String username, String email, String gender, String password, String confirmpassword, DateTime DOB)
        {
            
            if (username == "" | email == "" | gender == "" | password == "" | confirmpassword == "" | DOB.ToString() == "1/1/0001 12:00:00 AM")
            {
                return "All Fields Must be Filled";
            }
            else if (username.Length < 5 | username.Length > 15)
            {
                 return "Username Must be Between 5 to 15 Alphabet";
            }
            else if (email.Length < 4)
            {
                return "Email Must be More Than 4 Characters";
            }
            else if (email[email.Length - 4] != '.' | email[email.Length - 3] != 'c' | email[email.Length - 2] != 'o' | email[email.Length - 1] != 'm')
            {
                return "Email Must Ends With '.com'";
            }
            //TextBoxEmail.Text.Substring(TextBoxEmail.Text.IndexOf('.'))
            else if (password != confirmpassword)
            {
                return "Password With Confirmation Password Doesn't Match!";
            }
            return UserHandler.CreateNewUser(username, email, gender, password, confirmpassword, DOB);
        }

        public static String ValidateUserLogin(String username, String password)
        {
            if (username == "" | password == "")
            {
                return "Username or Password Must be Filled!";
            }
            return UserRepository.LoginUser(username, password);
        }

        public static String ValidateUpdateUser(int id, String username, String email, String gender, DateTime DOB)
        {
            if (username == "" | email == "" | gender == "" | DOB.ToString() == "1/1/0001 12:00:00 AM")
            {
                return "All Fields Must be Filled";
            }
            else if (username.Length < 5 | username.Length > 15)
            {
                return "Username Must be Between 5 to 15 Alphabet";
            }
            else if (email.Length < 4)
            {
                return "Email Must be More Than 4 Characters";
            }
            else if (email[email.Length - 4] != '.' | email[email.Length - 3] != 'c' | email[email.Length - 2] != 'o' | email[email.Length - 1] != 'm')
            {
                return "Email Must Ends With '.com'";
            }
            
            return UserHandler.UpdateUserProfile(id, username, email, gender, DOB);
        }

        public static string ValidateUpdatePassword(int id, String currentpassword, String newpassword, String confirmnewpassword)
        {
            if (currentpassword == "" | newpassword == "" | confirmnewpassword == "")
            {
                return "All Fields Must be Filled!";
            }
            else if(newpassword != confirmnewpassword)
            {
                return "New Password and Confirm Password Must be Same!";
            }
            return UserHandler.UpdateUserPassword(id, currentpassword, newpassword);
        }
    }
}