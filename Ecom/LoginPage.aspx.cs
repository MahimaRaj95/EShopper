using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecom
{
    public partial class LoginPage : System.Web.UI.Page
    {
        ConnectionCls oblog = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLog_Click(object sender, EventArgs e)
        {
            string s = "select count(Reg_Id) from Tb_Login where Username='" + txtUN.Text + "' and Password='" + txtPW.Text + "'";
            string ckid = oblog.Fn_Scalar(s).ToString();
            if(ckid=="1")
            {
                string getid= "select Reg_Id from Tb_Login where Username='" + txtUN.Text + "' and Password='" + txtPW.Text + "'";
                string userid = oblog.Fn_Scalar(getid).ToString();
                Session["UId"] = userid;
                string Strlogtype= "select Log_Type from Tb_Login where Username='" + txtUN.Text + "' and Password='" + txtPW.Text + "'";
                string logtype = oblog.Fn_Scalar(Strlogtype).ToString();
                if (logtype == "admin") 
                {
                    Label4.Text = "Welcome Admin";
                    Response.Redirect("AdminHomePage.aspx");
                }
                else if(logtype=="user")
                {
                    Label4.Text = "User Signed in";
                    Response.Redirect("UserHomePage.aspx");
                }
                else
                {
                    Label4.Text = "Invalid Credentials";
                }
            }
            else
            {
                Label4.Text= "Invalid Credentials";
            }

        }
    }
}