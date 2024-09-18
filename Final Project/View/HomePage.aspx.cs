using Final_Project.Master;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project.View
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/LoginPage.aspx");
            }

            GridViewCustomerData.DataSource = UserRepository.GetCustomerData();
            GridViewCustomerData.DataBind();
                
            GridViewCustomerData.HeaderRow.Cells[0].Text = "User ID";
            GridViewCustomerData.HeaderRow.Cells[1].Text = "Username";
            GridViewCustomerData.HeaderRow.Cells[2].Text = "Email";
            GridViewCustomerData.HeaderRow.Cells[3].Text = "Date of Birth";
            GridViewCustomerData.HeaderRow.Cells[4].Text = "Gender";
            GridViewCustomerData.HeaderRow.Cells[5].Text = "Role";
            GridViewCustomerData.HeaderRow.Cells[6].Text = "Password";

            HttpCookie userinfo = Request.Cookies["userrole_cookie"];
            string userrole = userinfo.Value;
            if (userrole == "Member")
            {
                GridViewCustomerData.Visible = false;
            }
            else if (userrole == "Admin")
            {
                GridViewCustomerData.Visible = true;
            }
        }

        protected void GridViewCustomerData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}