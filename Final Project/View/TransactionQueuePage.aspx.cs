using Final_Project.Controller;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project.View
{
    public partial class TransactionQueuePage : System.Web.UI.Page
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
                GridViewTransactionQueue.DataSource = TransactionHeaderRepository.GetAllTransaction();
                GridViewTransactionQueue.DataBind();

            }
            else if (userrole == "Member")
            {
                Response.Redirect("~/View/HomePage.aspx");
            }

        }

        protected void GridViewTransactionQueue_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GridViewTransactionQueue.Rows[e.NewEditIndex];
            String transactionIDTemp = row.Cells[1].Text;
            int transactionID = Convert.ToInt32(transactionIDTemp);
            String transactionStatus = row.Cells[4].Text;
            LabelInformation.Text = TransactionController.CheckTransactionStatus(transactionID, transactionStatus);

            if(LabelInformation.Text == "Order Successfully Handled!")
            {
                LabelInformation.ForeColor = System.Drawing.Color.Green;
                Response.Redirect("~/View/TransactionQueuePage.aspx");
            }
            else
            {
                LabelInformation.ForeColor = System.Drawing.Color.Red; 
            }
        }

        protected void GridViewTransactionQueue_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridViewTransactionQueue.Rows[e.RowIndex];
            String transactionID = row.Cells[1].Text;
            Response.Redirect("~/View/TransactionDetailPage.aspx?id=" + transactionID);
        }
    }
}