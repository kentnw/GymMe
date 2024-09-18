using Final_Project.Factory;
using Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Repository
{
    public class SupplementRepository
    {
        public static List<MsSupplementType> GetSupplementType()
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            return db.MsSupplementTypes.ToList();
        }
        public static List<MsSupplement> GetSupplementData()
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities ();
            return db.MsSupplements.ToList();
        }

        public static MsSupplement GetSupplementInfo(int supplementID)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsSupplement supplement = (from x in db.MsSupplements where x.SupplementID == supplementID select x).FirstOrDefault();
            return supplement;
        }

    }
}