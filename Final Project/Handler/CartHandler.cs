using Final_Project.Factory;
using Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Final_Project.Handler
{
    public class CartHandler
    {
        public static String CreateNewCart(int userid, int supplementid, int quantity)
        {
            MsCart cart = CartFactory.CreateNewCart(userid, supplementid, quantity);
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            db.MsCarts.Add(cart);
            db.SaveChanges();
            return "Succesfully Added To Cart!";
        }

        public static string ClearCart(int userid)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            List<MsCart> cart = (from x in db.MsCarts where x.UserID == userid select x).ToList();
            if(cart == null)
            {
                return "Cart is Already Empty!";
            }
            else
            {
                db.MsCarts.RemoveRange(cart);
                db.SaveChanges();
                return "Clear Cart Successful!";
            }
        }

        public static string deleteSupplement(int supplementID)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            //MsSupplement supplement = db.MsSupplements.Find(supplementID);
            MsSupplement supplement = db.MsSupplements.Where(x => x.SupplementID == supplementID).FirstOrDefault();
            db.MsSupplements.Remove(supplement);
            db.SaveChanges();
            return "Delete Success!";
        }
    }
}