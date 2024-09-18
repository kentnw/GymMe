using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project.Master
{
    public partial class NavigationBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }
            else
            {
                HttpCookie userinfo = Request.Cookies["userrole_cookie"];
                string userrole = userinfo.Value;
                if (userrole == "Member")
                {
                    ListAdminDiv.Visible = false;
                }
                else if (userrole == "Admin")
                {
                    ListMemberDiv.Visible = false;
                }
            }


        }

        protected void ButtonOrderSupplement_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/OrderSupplement.aspx");
        }

        protected void ButtonHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/HistoryPage.aspx");
        }

        protected void ButtonProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ProfilePage.aspx");
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Cookies.Remove("user_cookie");
            Response.Cookies.Remove("userid_cookie");
            Response.Cookies.Remove("userrole_cookie");
            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void ButtonHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void ButtonManageSupplement_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageSupplement.aspx");
        }

        protected void ButtonProfileAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ProfilePage.aspx");
        }

        protected void ButtonOrderQueue_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/TransactionQueuePage.aspx");
        }

        protected void ButtonTransactionReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/TransactionReport.aspx");
        }

        protected void ButtonLogoutAdmin_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Cookies.Remove("user_cookie");
            Response.Cookies.Remove("userid_cookie");
            Response.Cookies.Remove("userrole_cookie");
            Response.Redirect("~/View/LoginPage.aspx");
        }
    }
}