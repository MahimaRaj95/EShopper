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
    public partial class ProductsDisplay : System.Web.UI.Page
    {
        ConnectionCls ob = new ConnectionCls();

        public void Fn_ProDisply()
        {
            string selpro = "select * from Tb_Product where Pro_Id='" + Session["VPFUPID"] + "'";
            SqlDataReader rd = ob.Fn_Reader(selpro);
            while(rd.Read())
            {
                Image1.ImageUrl = rd["Pro_Image"].ToString();
                Label1.Text = rd["Pro_Name"].ToString();
                Label2.Text = rd["Pro_Description"].ToString();
                Label5.Text = rd["Pro_Price"].ToString();

            }
           
        }
        public string Subtotal()
        {
            string selprice = "select Pro_Price from Tb_Product where Pro_Id='" + Session["VPFUPID"] + "'";
            string s = ob.Fn_Scalar(selprice).ToString();
            //int tot = Convert.ToInt32(s) * Convert.ToInt32(TextBox1.Text);
            return s;
        }
        public int Subtotal1(int pc)
        {
            string selprice = "select Pro_Price from Tb_Product where Pro_Id='" + Session["VPFUPID"] + "'";
            string s = ob.Fn_Scalar(selprice).ToString();
            Session["rate"] = Convert.ToInt32(s);
            int tot = Convert.ToInt32(s) * pc;
            return tot;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Fn_ProDisply();
            }
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {

            int CID,PC;
            string Prdcount = "select count(Pro_Id) from Tb_Cart where Pro_Id=" + Session["VPFUPID"] + " and  User_Id=" + Session["UId"] + "";
            string proc = ob.Fn_Scalar(Prdcount).ToString();
            if (proc == "0")
            {
                PC = Convert.ToInt32(TextBox1.Text);
                int subttl1 = Subtotal1(PC);
                string gen_Id = "select max(Cart_Id) from Tb_Cart";
                string Cart_Id = ob.Fn_Scalar(gen_Id).ToString();
                if (Cart_Id == "")
                {
                    CID = Convert.ToInt32("1");
                }
                else
                {
                    CID = Convert.ToInt32(Cart_Id) + 1;

                }
                Session["CID"] = CID;
                string ins = "insert into Tb_Cart values("+CID+","+Session["UId"] +","+Session["VPFUPID"]+","+TextBox1.Text+","+ subttl1 + ","+Session["rate"]+")";
                int i = ob.Fn_Nonquery(ins);
                if (i == 1)
                {
                    Label6.Visible = true;
                    Label6.Text = "Successfully Added to Cart";
                    Response.Redirect("ViewCart.aspx");
                }
            }
            else
            {
                string ProQty= "select Pro_Qty from Tb_Cart where Pro_Id=" + Session["VPFUPID"] + " and  User_Id=" + Session["UId"] + "";
                string Pro_Qty = ob.Fn_Scalar(ProQty).ToString();
                PC = Convert.ToInt32(Pro_Qty) + Convert.ToInt32(TextBox1.Text);
                //int subttl1 = Subtotal1(PC);
                string upt = "update Tb_Cart set Pro_Qty=" + PC + ",Subtotal=" + Subtotal1(PC) + " ,Pro_rate="+Session["rate"]+" where Pro_Id=" + Session["VPFUPID"] + " and  User_Id=" + Session["UId"] + " ";
                int j = ob.Fn_Nonquery(upt);
                if (j == 1)
                {
                    Label6.Visible = true;
                    Label6.Text = "Successfully Added to Cart";
                    Response.Redirect("ViewCart.aspx");
                }
            }
           
            //int subtl = Subtotal();
           
           
           
           
            
           
        }
    }
}