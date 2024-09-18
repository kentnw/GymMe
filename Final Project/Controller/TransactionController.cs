using Final_Project.Handler;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Final_Project.Controller
{
    public class TransactionController
    {
        public static string CheckTransactionStatus(int transactionID, String status)
        {
            if(status == "Handled")
            {
                return "Order is Already Handled!";
            }
            else
            {
                return Handler.TransactionHandler.HandleTransaction(transactionID);
            }
        }
    }
}