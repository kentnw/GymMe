using Final_Project.Factory;
using Final_Project.Model;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Handler
{
    public class SupplementHandler
    {
        
        public static string CreateNewSupplement(string name, DateTime expiryDate, int price, string supplementType)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            int supplementTypeID = (from x in db.MsSupplementTypes where x.SupplementTypeName == supplementType select x.SupplementTypeID).FirstOrDefault();
            MsSupplement msSupplement = SupplementFactory.CreateNewSupplement(name, expiryDate, price, supplementTypeID);
            db.MsSupplements.Add(msSupplement);
            db.SaveChanges();
            return "Insert Supplement Success!";
        }

        public static string UpdateSupplement(int id, string name, DateTime expiryDate, int price, string supplementTypeName)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsSupplement msSupplement = (from x in db.MsSupplements where x.SupplementID == id select x).FirstOrDefault();
            msSupplement.SupplementName = name;
            msSupplement.SupplementExpiryDate = expiryDate;
            msSupplement.SupplementPrice = price;

            MsSupplementType supplementType = (from x in db.MsSupplementTypes where x.SupplementTypeName == supplementTypeName select x).FirstOrDefault();
            msSupplement.SupplementTypeID = supplementType.SupplementTypeID;
            db.SaveChanges();

            return "Update Successful!";
        }

        public static string deleteSupplement(int supplementID)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities ();
            //MsSupplement supplement = db.MsSupplements.Find(supplementID);
            MsSupplement supplement = db.MsSupplements.Where(x => x.SupplementID == supplementID).FirstOrDefault();
            db.MsSupplements.Remove(supplement);
            db.SaveChanges();
            return "Delete Success!";
        }
    }
}