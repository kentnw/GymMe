using Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Project.Repository
{
    public class TransactionDetailRepository
    {
        public static List<TransactionDetail> GetTransactionDetails(int transactionID)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            List<TransactionDetail> td = (from x in db.TransactionDetails where x.TransactionID == transactionID select x).ToList();
            if (td.Count == 0)
            {
                return null;
            }
            else
            {
                return td;
            }
        }
    }
}