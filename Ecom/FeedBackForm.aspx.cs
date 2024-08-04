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
    public partial class FeedBackForm : System.Web.UI.Page
    {
        ConnectionCls obcon = new ConnectionCls();

        public string ConvrtQts(string str)
        {
            return str.Replace("'", "''");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string feedbkins = "insert into Tb_Feedback values(" + Session["UID"] + ",'" + ConvrtQts(TextBox1.Text) + "','nil','not replied')";
            int i = obcon.Fn_Nonquery(feedbkins);
            if(i==1)
            {
                Panel1.Visible = false;
                TextBox1.Text = "";
                Label3.Visible = true;
                Label3.Text = "Thank you For Your feedback. We will get back you soon!";
               
            }
        }
    }
}