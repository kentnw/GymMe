using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project.View
{
    public partial class HistoryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }
            HttpCookie userinfo = Request.Cookies["userrole_cookie"];
            string userrole = userinfo.Value;
            HttpCookie userinfoid = Request.Cookies["userid_cookie"];
            int userID = Convert.ToInt32(userinfoid.Value);
            if (userrole == "Admin")
            {
                GridViewHistory.DataSource = TransactionHeaderRepository.GetAllTransaction();
                GridViewHistory.DataBind();

            }
            else if(userrole == "Member")
            {
                GridViewHistory.DataSource = TransactionHeaderRepository.GetTransactionList(userID);
                GridViewHistory.DataBind();
            }
            
        }

        protected void GridViewHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void GridViewHistory_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GridViewHistory.Rows[e.NewEditIndex];
            String transactionID = row.Cells[1].Text;
            Response.Redirect("~/View/TransactionDetailPage.aspx?id=" + transactionID);
        }
    }
}