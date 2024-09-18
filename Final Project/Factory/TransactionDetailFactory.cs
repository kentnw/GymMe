using Final_Project.Model;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail CreateTransactionDetail(int transactionID, int SupplementID, int quantity)
        {
            TransactionDetail transactionDetail = new TransactionDetail();
            transactionDetail.TransactionID = transactionID;
            transactionDetail.SupplementID = SupplementID;
            transactionDetail.Quantity = quantity;

            return transactionDetail;
        }
    }
}