using Final_Project.Factory;
using Final_Project.Model;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Handler
{
    public class TransactionDetailHandler
    {
        public static string CreateTransactionDetail(int userID, int transactionID)
        {
            List<MsCart> cart = CartRepository.GetCartDetail(userID);
            foreach(var item in cart)
            {
                int supplementID = item.SupplementID;
                int quantity = item.Quantity;
                TransactionDetail td = TransactionDetailFactory.CreateTransactionDetail(transactionID, supplementID, quantity);
                LocalDatabaseEntities db = new LocalDatabaseEntities();
                db.TransactionDetails.Add(td);
                db.SaveChanges();
            }
            return "Cart Checkout Successful!";

        }

        //public static TransactionDetail InsertTransactionDetail(int transactionID, List<MsCart> cart)
        //{
        //    int supplementID = cart.SupplementID;
        //    int quantity = cart.Quantity;

        //    LocalDatabaseEntities db = new LocalDatabaseEntities();
        //    TransactionDetail transactionDetail = new TransactionDetail();
        //    foreach(var item in cart)
        //    {
        //        transactionDetail.TransactionID = 19;
        //        transactionDetail.SupplementID = supplementID;
        //        transactionDetail.Quantity = quantity;
        //    }
            

        //    db.TransactionDetails.Add(transactionDetail);
        //    db.SaveChanges();

        //    return transactionDetail;
        //}
    }
}