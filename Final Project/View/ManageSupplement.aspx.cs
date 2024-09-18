using Final_Project.Controller;
using Final_Project.Handler;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project.View
{
    public partial class Manage_Supplement : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                GridViewManageSupplement.DataSource = SupplementRepository.GetSupplementData();
                GridViewManageSupplement.DataBind();
            }
            

            GridViewManageSupplement.HeaderRow.Cells[1].Text = "ID";
            GridViewManageSupplement.HeaderRow.Cells[2].Text = "Name";
            GridViewManageSupplement.HeaderRow.Cells[3].Text = "Expiry Date";
            GridViewManageSupplement.HeaderRow.Cells[4].Text = "Price";
            GridViewManageSupplement.HeaderRow.Cells[5].Text = "Type ID";
        }

        protected void GridViewManageSupplement_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
        protected void ButtonDelete_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void GridViewManageSupplement_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridViewManageSupplement.Rows[e.RowIndex];
            String rowIndex = row.Cells[1].Text;
            int supplementID;
            int.TryParse(rowIndex, out supplementID);
            LabelInformation.Text = SupplementHandler.deleteSupplement(supplementID);

            //GridViewManageSupplement.DataSource = SupplementRepository.GetSupplementData();
            //GridViewManageSupplement.DataBind();
            Response.Redirect("~/View/ManageSupplement.aspx");
        }

        protected void GridViewManageSupplement_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GridViewManageSupplement.Rows[e.NewEditIndex];
            String supplementID = row.Cells[1].Text;
            String supplementName = row.Cells[2].Text;
            String supplementDate = row.Cells[3].Text;
            String supplementPrice = row.Cells[4].Text;
            String supplementTypeID = row.Cells[5].Text;

            String updateurl = string.Format("~/View/UpdateSupplement.aspx?id={0}&name={1}&date={2}&price={3}&type={4}", supplementID, supplementName, supplementDate, supplementPrice, supplementTypeID);
            Response.Redirect(updateurl);
        }

        protected void ButtonInsertSupplement_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertSupplement.aspx");
        }
    }
}