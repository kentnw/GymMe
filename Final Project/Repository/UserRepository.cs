using Final_Project.Factory;
using Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI.WebControls;

namespace Final_Project.Repository
{
    public class UserRepository
    {

        public static string LoginUser(string username, string password)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            var user = (from x in db.MsUsers where x.UserName == username && x.UserPassword == password select x).FirstOrDefault();
            if (user == null)
            {
                return "Wrong Email or Password!";
            }

            return "Login Success!";
        }

        public static string GetUserID(string username)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            var user = (from x in db.MsUsers where x.UserName == username select x).FirstOrDefault();
            return user.UserID.ToString();
        }

        public static string GetUserRole(string username)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            var user = (from x in db.MsUsers where x.UserName == username select x).FirstOrDefault();
            return user.UserRole;
        }

        public static List<MsUser> GetCustomerData(){
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            return db.MsUsers.ToList();
        }

        public static MsUser GetUserProfile(int id)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            var user = (from x in db.MsUsers where x.UserID == id select x).FirstOrDefault();
            return user;
        }
    }
}