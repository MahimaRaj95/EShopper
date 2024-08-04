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
    public partial class PaymentPage : System.Web.UI.Page
    {
        ConnectionCls obcon = new ConnectionCls();
        ServiceReference4.ServiceClient ob = new ServiceReference4.ServiceClient();
        public void billgen()
        {
            string[] billdetail = new string[50];
            int getBill = 0;
            int count = 0;
            int total = 0;
            int j = 0;
            string[] ary = new string[50];
            string[] stkary = new string[50];
            string[] Cartary = new string[50];
            string dt = DateTime.Now.ToString();
            string cart = "select * from Tb_Cart where User_Id=" + Session["UID"] + "";
            SqlDataReader rd = obcon.Fn_Reader(cart);
            while (rd.Read())
            {
                string cart_id = rd["cart_Id"].ToString();
                string pro_id = rd["Pro_Id"].ToString();
                string Qty = rd["Pro_Qty"].ToString();
                string subtotal = rd["Subtotal"].ToString();
                //string ins = "insert into Tb_Order values(" + Session["UID"] + "," + Convert.ToInt32(pro_id) + ", " + Convert.ToInt32(Qty) + "," + Convert.ToInt32(subtotal) + ",'ordered','" + DateTime.Now.ToString("yyyy-MM-dd") + "')";
                string ins = "select Order_Id from Tb_Order where Order_Status='confirmed' and User_Id=" + Session["UID"] + "";
                //string stock = "select Pro_Id,Qty from Tb_Order where Order_Status='confirmed' and User_Id=" + Session["UID"] + "";
                total = total + Convert.ToInt32(subtotal);
                ary[j] = ins;
                Cartary[j] = cart_id;
                //stkary[j] = stock;
                j++;
                count++;

            }
            //Session["Total"] = total;

            for (int i = 0; i < count; i++)
            {

                string insStatus = obcon.Fn_Scalar(ary[i]);
                if (insStatus != "")
                {
                    int newqty=0, newproId=0;
                    string delcart = "delete from Tb_Cart where cart_Id=" + Convert.ToInt32(Cartary[i]) + "";
                    int delStatus = obcon.Fn_Nonquery(delcart);
                    string orderstatus= "update Tb_Order set Order_status='paid' where Order_Id="+ Convert.ToInt32(insStatus) + "";
                  
                    int x = obcon.Fn_Nonquery(orderstatus);
                    string stock = "select Pro_Id,Qty from Tb_Order where Order_Id=" + Convert.ToInt32(insStatus) + "";
                    stkary[i] = stock;
                    SqlDataReader rd2 = obcon.Fn_Reader(stkary[i]);
                    while(rd2.Read())
                    {
                        newqty =Convert.ToInt32( rd2["Qty"].ToString());
                        newproId= Convert.ToInt32(rd2["Pro_Id"].ToString());
                    }
                    string stkupdt = "update Tb_Product set Pro_Stock=Pro_Stock-"+newqty+" where Pro_Id=" + newproId + "";
                    int y = obcon.Fn_Nonquery(stkupdt);
                }

            }
            string getbill = "select max(Bill_Id) from Tb_Bill";
            string getbillid = obcon.Fn_Scalar(getbill).ToString();

            if (getbillid == "")
            {
                getBill = 1;
            }
            else
            {
                getBill = Convert.ToInt32(getbillid) + 1;
            }
            string billins = "insert into Tb_Bill values(" + getBill + "," + Session["UID"] + "," + total + ",'" + DateTime.Now.ToString("MM-yy-dd") + "','new')";
            int k = obcon.Fn_Nonquery(billins);
            //if (k == 1)
            //{
            //    Response.Redirect("ViewBill.aspx");
            //}
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //billgen();
            Label4.Text = Session["Total"].ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            decimal userbalance=ob.Balance_Check(TextBox1.Text);
            if(Convert.ToInt32(Session["Total"])<=userbalance)
            {
                billgen();
                decimal crntBal = userbalance-Convert.ToInt32(Session["Total"]);

                decimal i = ob.Balance_Updt(TextBox1.Text, crntBal);
                Response.Redirect("Reciept.aspx");
            }
            else
            {
                Label7.Text = "Insufficient Balance";
            }
        }
    }
}