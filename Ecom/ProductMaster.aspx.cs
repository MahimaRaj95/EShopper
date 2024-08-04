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
    public partial class ProductMaster : System.Web.UI.Page
    {
        ConnectionCls ob = new ConnectionCls();
        public void Fn_GdView()
        {
            string sel = "select * from Tb_Category";
            DataSet ds = ob.Fn_Adapter(sel);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "CTG_Name";
            DropDownList1.DataValueField = "CTG_Id";
            DropDownList1.DataBind();

        }
        public string ConvrtQts(string str)
        {
            return str.Replace("'", "''");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Fn_GdView();

        }

        protected void btnSav_Click(object sender, EventArgs e)
        {
            string img = "~/PH/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(img));
            string ins = "insert into Tb_Product values(" + DropDownList1.SelectedItem.Value + ",'" + ConvrtQts(txtName.Text) + "'," + txtPrice.Text + ",'" + img + "','" + ConvrtQts(txtDesc.Text) + "'," + txtStock.Text + ",'" + rbStatus.SelectedItem.Text + "')";
            int i = ob.Fn_Nonquery(ins);
            if (i == 1)
            {
                lblSts.Visible = true;
                lblSts.Text = "Product created successfully";
                txtName.Text = "";
                txtDesc.Text = "";

            }
        }
    }
}