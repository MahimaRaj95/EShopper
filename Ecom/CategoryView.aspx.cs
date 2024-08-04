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
    public partial class CategoryView : System.Web.UI.Page
    {
        ConnectionCls ob = new ConnectionCls();
        public void Fn_GdView()
        {
            string sel = "select * from Tb_Category";
            DataSet ds = ob.Fn_Adapter(sel);
            GVCtg.DataSource = ds;
            GVCtg.DataBind();
          
        }
        public string ConvrtQts(string str)
        {
           return str.Replace("'", "''");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
            Fn_GdView();
                
            }
           

        }

        protected void GVCtg_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow rw = GVCtg.Rows[e.NewSelectedIndex];
            Session["Cid"] = rw.Cells[1].Text;
            string ctg = "select * from Tb_Category where CTG_Id=" + Session["Cid"] + " ";
            SqlDataReader rd = ob.Fn_Reader(ctg);
            Panel1.Visible = true;
            while(rd.Read())
            {
                txtName.Text = rd["CTG_Name"].ToString();
                Image1.ImageUrl = rd["CTG_Image"].ToString();
                txtDesc.Text= rd["CTG_Description"].ToString();
                string st = rd["CTG_Status"].ToString();
                if (st=="Available")
                {
                    RadioButtonList1.Items[0].Selected = true;

                }
                else
                {
                    RadioButtonList1.Items[1].Selected = true;
                }
                
               
            }
            //txtName.Text = rw.Cells[2].Text;
            //Image1.ImageUrl = rw.Cells[3].Text;


        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            string upt = "update Tb_Category set CTG_Name='" + ConvrtQts(txtName.Text) + "',CTG_Description='" + ConvrtQts(txtDesc.Text) + "',CTG_Status='" + RadioButtonList1.SelectedItem.Text + "' ";
            if(FileUpload1.FileName!="")
            {
                string img = "~/PH/" + FileUpload1.FileName;
                FileUpload1.SaveAs(MapPath(img));
                upt = upt + ",CTG_Image='" + img + "'";
            }
           
          
            upt = upt + "where CTG_Id=" + Session["Cid"] + "";
            int chkupt = ob.Fn_Nonquery(upt);
            if(chkupt==1)
            {
                Fn_GdView();
                lblSts.Text = "Category Updated ";
                
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminHomePage.aspx");
        }
    }
}