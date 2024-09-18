using Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Factory
{
    public class CartFactory
    {
        public static MsCart CreateNewCart(int userid, int supplementid, int quantity)
        {
            MsCart newCart = new MsCart();
            newCart.UserID = userid;
            newCart.SupplementID = supplementid;
            newCart.Quantity = quantity;
            return newCart;
        }
    }
}