using Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Factory
{
    public class SupplementFactory
    {
        public static MsSupplement CreateNewSupplement(string name, DateTime expiryDate, int price, int typeID)
        {
            MsSupplement newSupplement = new MsSupplement();
            newSupplement.SupplementName = name;
            newSupplement.SupplementExpiryDate = expiryDate;
            newSupplement.SupplementPrice = price;
            newSupplement.SupplementTypeID = typeID;
            return newSupplement;
        }
    }
}