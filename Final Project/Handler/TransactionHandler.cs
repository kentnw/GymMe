using Final_Project.Model;
using Final_Project.Repository;
using Final_Project.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Final_Project.Handler
{
    public class TransactionHandler
    {
        public static String HandleTransaction(int transactionID)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            TransactionHeader th = (from x in db.TransactionHeaders where x.TransactionID == transactionID select x).FirstOrDefault();
            th.Status = "Handled";
            db.SaveChanges();

            return "Order Successfully Handled!";
        }

        public static List<TransactionHeader> GetTransactionHeaders()
        {
            return TransactionHeaderRepository.GetTransactions();
        }
    }
}