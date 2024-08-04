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
    public partial class UserHomePage : System.Web.UI.Page
    {
        ConnectionCls ob = new ConnectionCls();
        public void Fn_GdCatView()
        {
            string selcat = "select * from Tb_Category";
            DataSet ds = ob.Fn_Adapter(selcat);
            DataList1.DataSource = ds;
            DataList1.DataBind();

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Fn_GdCatView();
            }

        }

        //protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        //{
        //    Response.Redirect("ViewProducts_ForUser.aspx");
        //}

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            Session["UHPCID"] = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("ViewProducts_ForUser.aspx");
        }
    }
}