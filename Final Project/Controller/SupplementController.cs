using Final_Project.Factory;
using Final_Project.Handler;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Final_Project.Controller
{
    public class SupplementController
    {
        public static string InsertSupplement(string name, DateTime expirydate, int price, string type)
        {
            if(name == "" || expirydate.ToString() == "1/1/0001 12:00:00 AM" || price == 0)
            {
                return "All Fields Must be Filled!";
            }
            else if(name.Contains("Supplement") == false)
            {
                return "Name Must Contain Supplement!";
            }
            else if(expirydate <= DateTime.Today)
            {
                return "Expiry Date Must be Greater Than Today!";
            }
            else if(price < 3000)
            {
                return "Price Must be At Least 3000!";
            }
            else if(type == "Select")
            {
                return "Supplement Type Cannot be Empty!";
            }
            return SupplementHandler.CreateNewSupplement(name, expirydate, price, type);
        }

        public static string UpdateSupplement(int id, string name, DateTime expirydate, int price, string type)
        {
            if (name == "" || expirydate.ToString() == "1/1/0001 12:00:00 AM" || price == 0)
            {
                return "All Fields Must be Filled!";
            }
            else if (name.Contains("Supplement") == false)
            {
                return "Name Must Contain Supplement!";
            }
            else if (expirydate <= DateTime.Today)
            {
                return "Expiry Date Must be Greater Than Today!";
            }
            else if (price < 3000)
            {
                return "Price Must be At Least 3000!";
            }
            else if (type == "Select")
            {
                return "Supplement Type Cannot be Empty!";
            }
            return SupplementHandler.UpdateSupplement(id, name, expirydate, price, type);
        }
    }
}