using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project.View
{
    public partial class TransactionDetailPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }
            HttpCookie userinfo = Request.Cookies["userid_cookie"];
            int userID = Convert.ToInt32(userinfo.Value);

            String transactionIDTemp = Request["id"];
            int transactionID = Convert.ToInt32(transactionIDTemp);
            GridViewTransactionDetail.DataSource = TransactionDetailRepository.GetTransactionDetails(transactionID);
            GridViewTransactionDetail.DataBind();

        }
    }
}