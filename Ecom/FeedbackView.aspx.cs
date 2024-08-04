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
    public partial class FeedbackView : System.Web.UI.Page
    {
        ConnectionCls oblog = new ConnectionCls();
        public void Fn_GdView()
        {
            string sel = "select * from Tb_FeedBack as T1 inner join Tb_User_Reg as T2 on T1.User_Id=T2.User_Reg_Id";
            DataSet ds = oblog.Fn_Adapter(sel);
            GdvFeedback.DataSource = ds;
            GdvFeedback.DataBind();
        }

            protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            Fn_GdView();
            //Response.Redirect("SendReply.aspx");
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            Session["FeedBackUser"] = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("SendReply.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            //Response.Redirect("SendReply.aspx");
        }
    }
}