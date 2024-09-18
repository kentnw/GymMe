using Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Factory
{
    public class UserFactory
    {
        public static MsUser CreateNewUser(String username, String email, String gender, String password, String confirmpassword, DateTime DOB)
        {
            MsUser newUser = new MsUser();
            newUser.UserName = username;
            newUser.UserEmail = email;
            newUser.UserGender = gender;
            newUser.UserPassword = password;
            newUser.UserDOB = DOB;
            newUser.UserRole = "Member";
            return newUser;
        }
    }
}