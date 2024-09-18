using Final_Project.Factory;
using Final_Project.Model;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Handler
{
    public class UserHandler
    {
        public static String CreateNewUser(String username, String email, String gender, String password, String confirmpassword, DateTime DOB)
        {
            MsUser user = UserFactory.CreateNewUser(username, email, gender, password, confirmpassword, DOB);
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            db.MsUsers.Add(user);
            db.SaveChanges();
            return "Registration Success!";
        }

        public static String UpdateUserProfile(int id, String username, String email, String gender, DateTime DOB)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsUser msUser = (from x in db.MsUsers where x.UserID == id select x).FirstOrDefault();
            msUser.UserName = username;
            msUser.UserEmail = email;
            msUser.UserGender = gender;
            msUser.UserDOB = DOB;
            db.SaveChanges();

            return "Update Profile Successful!";
        }
        
        public static String UpdateUserPassword(int id, String currentpassword, String newpassword)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsUser msUser = (from x in db.MsUsers where x.UserID == id && x.UserPassword == currentpassword select x).FirstOrDefault();
            if(msUser == null)
            {
                return "Current Password Doesn't Match!";
            }
            else
            {
                msUser.UserPassword = newpassword;
                db.SaveChanges();
                return "Update Password Successful!";
            }

        }
    }
}