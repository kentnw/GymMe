using Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Repository
{
    public class CartRepository
    {
        public static List<MsCart> GetCartDetail(int userid)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            List<MsCart> cart = (from x in db.MsCarts where x.UserID == userid select x).ToList();
            if(cart.Count == 0)
            {
                return null;
            }
            else
            {
                return cart;
            }
        }

        public static void DeleteCart(int cartid)
        {

        }
    }
}