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
    public partial class ViewProducts_ForUser : System.Web.UI.Page
    {
        ConnectionCls ob = new ConnectionCls();
        public void Fn_GdProView()
        {
            string selcat = "select * from Tb_Product where CTG_Id='"+ Session["UHPCID"]+"'";
            DataSet ds = ob.Fn_Adapter(selcat);
            DataList1.DataSource = ds;
            DataList1.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Fn_GdProView();
            }

        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            Session["VPFUPID"] = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("ProductsDisplay.aspx");
        }
    }
}