using Final_Project.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Controller
{
    public class CartController
    {
        public static string OrderSupplement(int userid, int supplementid, int quantity)
        {
            if (quantity < 0)
            {
                return "Quantity Must be Atleast 1!";
            }
            else
            {
                return CartHandler.CreateNewCart(userid, supplementid, quantity);
            }
        }
    }
}