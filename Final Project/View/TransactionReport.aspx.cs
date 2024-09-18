using Final_Project.Dataset;
using Final_Project.Handler;
using Final_Project.Model;
using Final_Project.Report;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project.View
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }
            HttpCookie userinfo = Request.Cookies["userrole_cookie"];
            string userrole = userinfo.Value;
            if (userrole == "Member")
            {
                Response.Redirect("~/View/HomePage.aspx");
            }

            CrystalReport1 report = new CrystalReport1();
            CrystalReportViewer1.ReportSource = report;
            DataSetGymMe data = getData(Handler.TransactionHandler.GetTransactionHeaders());
            report.SetDataSource(data);
        }

        private DataSetGymMe getData(List<TransactionHeader> th)
        {
            DataSetGymMe data = new DataSetGymMe();
            var headertable = data.TransactionHeader;
            var detailtable = data.TransactionDetail;

            foreach (TransactionHeader t in th)
            {
                var hrow = headertable.NewRow();
                hrow["TransactionID"] = t.TransactionID;
                hrow["UserID"] = t.UserID;
                hrow["TransactionDate"] = t.TransactionDate;
                headertable.Rows.Add(hrow);

                foreach (TransactionDetail d in t.TransactionDetails)
                {
                    var drow = detailtable.NewRow();
                    drow["TransactionID"] = d.TransactionID;
                    drow["SupplementID"] = d.SupplementID;
                    drow["Quantity"] = d.Quantity;
                    detailtable.Rows.Add(drow);

                    var supplement = SupplementRepository.GetSupplementInfo(d.SupplementID);
                    //if (supplement != null && !IsSupplementInTable(supplementTable, supplement.SupplementID))
                    //{
                    //    var crow = supplementTable.NewRow();
                    //    crow["SupplementID"] = supplement.SupplementID;
                    //    crow["SupplementName"] = supplement.SupplementName;
                    //    crow["SupplementExpiryDate"] = supplement.SupplementExpiryDate;
                    //    crow["SupplementPrice"] = supplement.SupplementPrice;
                    //    crow["SupplementTypeID"] = supplement.SupplementTypeID;
                    //    supplementTable.Rows.Add(crow);
                    //}
                }
            }
            return data;
        }
    }
}