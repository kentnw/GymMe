using Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader CreateTransactionHeader(int userID, DateTime transactiondate, String status)
        {
            TransactionHeader th = new TransactionHeader();
            th.UserID = userID;
            th.TransactionDate = transactiondate;
            th.Status = status;
            return th;
        }
    }
}