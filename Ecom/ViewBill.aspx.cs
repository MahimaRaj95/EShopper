using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Ecom
{
    public partial class ViewBill : System.Web.UI.Page
    {
        ConnectionCls ob = new ConnectionCls();
        public void Fn_GdView_Bill()
        {
            //string bill = "select T3.Bill_Date,T1.User_Id,T1.Pro_Id,T1.Qty,T1.Subtotal,T2.Pro_Price,T2.Pro_Name from Tb_Order as T1 join Tb_Product as T2 on T1.Pro_Id=T2.Pro_Id left join Tb_Bill as T3 on T3.User_Id=T1.User_Id  where T1.User_Id=" + Session["UID"] + " and T3.status='new'";
            string bill = "select T1.Order_Date,T1.User_Id,T1.Pro_Id,T1.Qty,T1.Subtotal,T2.Pro_Price,T2.Pro_Name from Tb_Order as T1 join Tb_Product as T2 on T1.Pro_Id=T2.Pro_Id where T1.User_Id=" + Session["UID"] + " and T1.Order_Status='ordered' ";
            //string billview = "select Bill_Id,Total_Amt,Bill_Date from Tb_Bill User_Id=" + Session["UID"] + "";
            DataSet ds = ob.Fn_Adapter(bill);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] array = new string[50];
            //array = Session["ary"].ToString();
            Fn_GdView_Bill();
            Label12.Text = Session["Total"].ToString();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string orderconf= "update Tb_Order set Order_Status='confirmed' where User_Id=" + Session["UID"] + " ";
            int ordconfsts = ob.Fn_Nonquery(orderconf);
            Response.Redirect("PaymentPage.aspx");
        }
    }
}