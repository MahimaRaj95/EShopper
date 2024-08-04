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
    public partial class ViewCart : System.Web.UI.Page
    {
        ConnectionCls ob = new ConnectionCls();
        public void Fn_GdView_Cart()
        {
            string cartview = "select T1.User_Id,T1.Cart_Id,T1.Pro_Id,T1.Pro_Qty,T1.Subtotal,T2.Pro_Name,T1.Pro_Rate,T2.Pro_Image,T2.Pro_Status from Tb_Cart as T1 join Tb_Product as T2 on T1.Pro_Id=T2.Pro_Id where T1.User_Id=" + Session["UID"] + " ";
            DataSet ds = ob.Fn_Adapter(cartview);
            DataList1.DataSource = ds;
            DataList1.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            Fn_GdView_Cart();

        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int getcatrid = Convert.ToInt32(e.CommandArgument);
            string del = "delete from Tb_Cart where Cart_Id=" + getcatrid + "";
            int j=ob.Fn_Nonquery(del);
            Fn_GdView_Cart();
        }

        protected void ImageButton6_Command(object sender, CommandEventArgs e)
        {
            int getcatrid = Convert.ToInt32(e.CommandArgument);
            string del = "delete from Tb_Cart where Cart_Id=" + getcatrid + "";
            int j = ob.Fn_Nonquery(del);
            Fn_GdView_Cart();

        }

        protected void imgPlus_Click(object sender, ImageClickEventArgs e)
        {
            
        }

        protected void imgPlus_Command(object sender, CommandEventArgs e)
        {
            //int uptqty;
            string Qnty, price,upt;
            int getcatrid = Convert.ToInt32(e.CommandArgument);
            string qtyid= "select * from Tb_Cart where Cart_Id=" + getcatrid + "";
            SqlDataReader rd = ob.Fn_Reader(qtyid);
            if(rd.Read())
            {
                 Qnty = rd["Pro_Qty"].ToString();
                price = rd["Pro_Rate"].ToString();
               int uptqty = Convert.ToInt32(Qnty) + 1;
                int uptprice = uptqty * Convert.ToInt32(price);
                 upt = "Update Tb_Cart set Pro_Qty=" + uptqty + ",Subtotal=" + uptprice + " where Cart_Id=" + getcatrid + "";
                ob.Fn_Nonquery(upt);
            }

            Fn_GdView_Cart();

        }

        protected void imgMinus_Command(object sender, CommandEventArgs e)
        {
            string Qnty, price, upt;
            int getcatrid = Convert.ToInt32(e.CommandArgument);
            string qtyid = "select * from Tb_Cart where Cart_Id=" + getcatrid + "";
            SqlDataReader rd = ob.Fn_Reader(qtyid);
            if (rd.Read())
            {
                Qnty = rd["Pro_Qty"].ToString();
                if(Convert.ToInt32(Qnty)==1)
                {
                    //int getcatrid = Convert.ToInt32(e.CommandArgument);
                    string del = "delete from Tb_Cart where Cart_Id=" + getcatrid + "";
                    int j = ob.Fn_Nonquery(del);
                   
                    Response.Redirect("ViewCart.aspx");
                }
                price = rd["Pro_Rate"].ToString();
                int uptqty = Convert.ToInt32(Qnty) - 1;
                int uptprice = uptqty * Convert.ToInt32(price);
                upt = "Update Tb_Cart set Pro_Qty=" + uptqty + ",Subtotal=" + uptprice + " where Cart_Id=" + getcatrid + "";
                ob.Fn_Nonquery(upt);
            }

             Fn_GdView_Cart();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string[] billdetail = new string[50];
            //int getBill=0;
            int count = 0;
            int total=0;
            int j = 0;
            string[] ary = new string[50];
            string[] Cartary = new string[50];
            string dt = DateTime.Now.ToString();
            string cart= "select * from Tb_Cart where User_Id=" + Session["UID"] + "";
            SqlDataReader rd = ob.Fn_Reader(cart);
           while(rd.Read())
            {
                string cart_id = rd["cart_Id"].ToString();
                string pro_id = rd["Pro_Id"].ToString();
                string Qty = rd["Pro_Qty"].ToString();
                string subtotal = rd["Subtotal"].ToString();
                string ins = "insert into Tb_Order values(" + Session["UID"] + "," + Convert.ToInt32(pro_id) + ", " + Convert.ToInt32(Qty) + "," + Convert.ToInt32(subtotal) + ",'ordered','" + DateTime.Now.ToString("yyyy-MM-dd")+"')";
             
                total = total + Convert.ToInt32(subtotal);
                ary[j] = ins;
                Cartary[j] = cart_id;
                j++;
                count++;
                
            }
            Session["Total"] = total;
          
            for(int i=0;i<count;i++)
            {
                
                int insStatus = ob.Fn_Nonquery(ary[i]);
                //if(insStatus==1)
                //{
                //    string delcart = "delete from Tb_Cart where cart_Id=" + Convert.ToInt32(Cartary[i])+ "";
                //    int delStatus = ob.Fn_Nonquery(delcart);
                //}
               
            }
            //string getbill = "select max(Bill_Id) from Tb_Bill";
            //string getbillid = ob.Fn_Scalar(getbill).ToString();

            //if(getbillid=="")
            //{
            //    getBill = 1;
            //}
            //else
            //{
            //    getBill = Convert.ToInt32(getbillid) + 1;
            //}
            //string billins = "insert into Tb_Bill values("+ getBill+"," + Session["UID"] + "," + total + ",'" + DateTime.Now.ToString("MM-yy-dd") + "','new')";
            //int k = ob.Fn_Nonquery(billins);
            //if(k==1)
            //{
            //    Response.Redirect("ViewBill.aspx");
            //}
            Response.Redirect("ViewBill.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserHomePage.aspx");
        }
    }
}