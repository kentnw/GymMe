using Final_Project.Controller;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project.View
{
    public partial class UpdateSupplement : System.Web.UI.Page
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
                DropDownSupplementType.DataSource = SupplementRepository.GetSupplementType();
                DropDownSupplementType.DataTextField = "SupplementTypeName";
                DropDownSupplementType.DataBind();

                String supplementID = Request["id"];
                String supplementName = Request["name"];
                String supplementDateTemp = Request["date"];
                DateTime supplementDate = DateTime.Parse(supplementDateTemp);
                String supplementPrice = Request["price"];
                String supplementType = Request["type"];
                int supplementTypeID = int.Parse(supplementType);
                
                LabelID.Text = supplementID;
                TextBoxSupplementName.Text = supplementName;
                TextBoxSupplementPrice.Text = supplementPrice; 
                CalendarExpiryDate.SelectedDate = supplementDate;

                DropDownSupplementType.SelectedIndex = supplementTypeID - 1;
            }

            
        }

        protected void ButtonUpdateSupplement_Click(object sender, EventArgs e)
        {
            int supplementID = int.Parse(LabelID.Text);
            String supplementName = TextBoxSupplementName.Text;
            DateTime supplementDate = CalendarExpiryDate.SelectedDate;
            int supplementPrice = int.Parse(TextBoxSupplementPrice.Text);
            string supplementType = DropDownSupplementType.Text;
            LabelInformation.Text = SupplementController.UpdateSupplement(supplementID, supplementName, supplementDate, supplementPrice, supplementType);
            if(LabelInformation.Text == "Update Successful!")
            {
                LabelInformation.ForeColor = System.Drawing.Color.Green;
                Response.Redirect("~/View/ManageSupplement.aspx");
            }
            else
            {
                LabelInformation.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}