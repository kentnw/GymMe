using Final_Project.Controller;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project.View
{
    public partial class InsertSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/Loginpage.aspx");
            }

            HttpCookie userinfo = Request.Cookies["userrole_cookie"];
            string userrole = userinfo.Value;
            if (userrole == "Members")
            {
                Response.Redirect("~/View/HomePage.aspx");
            }

            if (!IsPostBack)
            {
                DropDownSupplementType.DataSource = SupplementRepository.GetSupplementType();
                DropDownSupplementType.DataTextField = "SupplementTypeName";
                DropDownSupplementType.DataBind();

            }
            
        }

        protected void ButtonInsertSupplement_Click(object sender, EventArgs e)
        {
            string name = TextBoxSupplementName.Text;
            DateTime expiryDate = CalendarExpiryDate.SelectedDate;
            string intvalue = TextBoxSupplementPrice.Text;
            int price;
            int.TryParse(intvalue, out price);
            string supplementType = DropDownSupplementType.Text;
            LabelInformation.Text = SupplementController.InsertSupplement(name, expiryDate, price, supplementType);
            
            if(LabelInformation.Text == "Insert Supplement Success!")
            {
                Response.Redirect("~/View/ManageSupplement.aspx");
            }
        }

        protected void DropDownSupplementType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}