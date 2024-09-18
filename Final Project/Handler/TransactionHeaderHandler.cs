using Final_Project.Factory;
using Final_Project.Model;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Final_Project.Handler
{
    public class TransactionHeaderHandler
    {
        public static int CreateTransactionHeader(int userID)
        {
            DateTime transactiondate = DateTime.Now;
            TransactionHeader th = TransactionHeaderFactory.CreateTransactionHeader(userID, transactiondate, "Unhandled");
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            int currenttransactionID = th.TransactionID;
            db.TransactionHeaders.Add(th);
            db.SaveChanges();

            return currenttransactionID;
        }

        
    }
}