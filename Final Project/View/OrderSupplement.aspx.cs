using Final_Project.Controller;
using Final_Project.Handler;
using Final_Project.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project.View
{
    public partial class OrderSupplement : System.Web.UI.Page
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
                Response.Redirect("~/View/HomePage.aspx");
            }
            if (!IsPostBack)
            {
                GridViewOrderSupplement.DataSource = SupplementRepository.GetSupplementData();
                GridViewOrderSupplement.DataBind();
                //GridViewOrderSupplement.Columns[1].Visible = false;
                var datasource1 = SupplementRepository.GetSupplementData();
                var datasource2 = SupplementRepository.GetSupplementType();
                //var mergedsource = datasource1.Concat(datasource2).ToList();
                //GridViewOrderSupplement.Columns.Add();
            }
            GridViewOrderSupplement.HeaderRow.Cells[0].Text = "Quantity";
            GridViewOrderSupplement.HeaderRow.Cells[1].Text = "Order";
            GridViewOrderSupplement.HeaderRow.Cells[2].Text = "Supplement ID";
            GridViewOrderSupplement.HeaderRow.Cells[3].Text = "Name";
            GridViewOrderSupplement.HeaderRow.Cells[4].Text = "Expiry Date";
            GridViewOrderSupplement.HeaderRow.Cells[5].Text = "Price";
            GridViewOrderSupplement.HeaderRow.Cells[6].Text = "Supplement Type ID";

            GridViewCart.DataSource = CartRepository.GetCartDetail(userID);
            GridViewCart.DataBind();

            if(GridViewCart.DataSource == null)
            {
                ButtonClearCart.Visible = false;
                ButtonCheckout.Visible = false;
            }
            else
            {
                GridViewCart.HeaderRow.Cells[0].Text = "Cart ID";
                GridViewCart.HeaderRow.Cells[1].Text = "User ID";
                GridViewCart.HeaderRow.Cells[2].Text = "Supplement ID";
                GridViewCart.HeaderRow.Cells[3].Text = "Quantity";
            }
            
        }

        protected void GridViewOrderSupplement_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        protected void GridViewOrderSupplement_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            HttpCookie userinfo = Request.Cookies["userid_cookie"];
            int userID = Convert.ToInt32(userinfo.Value);
            GridViewRow row = GridViewOrderSupplement.Rows[e.RowIndex];
            GridView gv = (GridView)sender;
            GridViewRow gvRow = gv.Rows[e.RowIndex];
            TextBox tb = (TextBox)gvRow.FindControl("TextBoxQuantity");
            int quantity = Convert.ToInt32(tb.Text);
            int supplementid = Convert.ToInt32(row.Cells[2].Text);
            int supplementtypeid = Convert.ToInt32(row.Cells[6].Text);
            LabelInformation.Text = CartController.OrderSupplement(userID, supplementid, quantity);
            if(LabelInformation.Text == "Succesfully Added To Cart!")
            {
                LabelInformation.ForeColor = System.Drawing.Color.Green;
                Response.Redirect("~/View/OrderSupplement.aspx");
            }
        }

        protected void ButtonClearCart_Click(object sender, EventArgs e)
        {
            HttpCookie userinfo = Request.Cookies["userid_cookie"];
            int userID = Convert.ToInt32(userinfo.Value);
            LabelCartInformation.Text = CartHandler.ClearCart(userID);
            if(LabelCartInformation.Text == "Clear Cart Successful!")
            {
                Response.Redirect("~/View/OrderSupplement.aspx");
            }

        }

        protected void ButtonCheckout_Click(object sender, EventArgs e)
        {
            HttpCookie userinfo = Request.Cookies["userid_cookie"];
            int userID = Convert.ToInt32(userinfo.Value);
            TransactionHeaderHandler.CreateTransactionHeader(userID);
            int currenttransaction = 33;
            TransactionHeaderRepository.GetLastTransactionHeaderID(userID);
            LabelCartInformation.Text = TransactionDetailHandler.CreateTransactionDetail(userID, currenttransaction);
            CartHandler.ClearCart(userID);
        }
    }
}