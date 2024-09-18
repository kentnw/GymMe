using Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Repository
{
    public class TransactionHeaderRepository
    {
        public static int GetLastTransactionHeaderID(int userID)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            TransactionHeader th = (from x in db.TransactionHeaders where x.UserID == userID orderby x.UserID descending select x).FirstOrDefault();
            return th.TransactionID;
        }

        public static List<TransactionHeader> GetAllTransaction()
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            List<TransactionHeader> th = db.TransactionHeaders.ToList();
            return th;
        }

        public static List<TransactionHeader> GetTransactionList(int userID)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            List<TransactionHeader> th = (from x in db.TransactionHeaders where x.UserID == userID select x).ToList();
            return th;
        }

        public static List<TransactionHeader> GetTransactions()
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            return db.TransactionHeaders.ToList();
        }
    }
}