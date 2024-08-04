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
    public partial class ProductView : System.Web.UI.Page
    {
        ConnectionCls ob = new ConnectionCls();
        public void Fn_GdView()
        {
            string sel = "select * from Tb_Product";
            DataSet ds = ob.Fn_Adapter(sel);
            GdvPdct.DataSource = ds;
            GdvPdct.DataBind();

        }
        public void Fn_GdCatView()
        {
            string selcat= "select * from Tb_Category";
            DataSet ds = ob.Fn_Adapter(selcat);
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "CTG_Name";
            DropDownList1.DataValueField = "CTG_Id";
            DropDownList1.DataBind();

        }
        public void Fn_View()
        {
            //GridViewRow rw = GdvPdct.Rows[e.NewSelectedIndex];
            //Session["Pid"] = rw.Cells[1].Text;
            string pro = "select * from Tb_Product where Pro_Id=" + Session["Pid"] + " ";
            Fn_GdCatView();
            Label1.Visible = true;
            Panel1.Visible = true;
            SqlDataReader rd = ob.Fn_Reader(pro);
            while (rd.Read())
            {
                txtName.Text = rd["Pro_Name"].ToString();
                txtPrice.Text = rd["Pro_Price"].ToString();
                Image1.ImageUrl = rd["Pro_Image"].ToString();
                txtDesc.Text = rd["Pro_Description"].ToString();
                txtStock.Text = rd["Pro_Stock"].ToString();
                string st = rd["Pro_Status"].ToString();
                string CTgid = rd["CTG_Id"].ToString();
                if (st == "Available")
                {
                    RadioButtonList1.Items[0].Selected = true;

                }
                else
                {
                    RadioButtonList1.Items[1].Selected = true;
                }
                DropDownList1.Items[Convert.ToInt32(CTgid) - 1].Selected = true;

            }
        }
        public string ConvrtQts(string str)
        {
            return str.Replace("'", "''");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Fn_GdView();

            }


        }



        protected void GdvPdct_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow rw = GdvPdct.Rows[e.NewSelectedIndex];
            Session["Pid"] = rw.Cells[1].Text;
            string pro = "select * from Tb_Product where Pro_Id=" + Session["Pid"] + " ";
            Fn_GdCatView();
            Panel1.Visible = true;
            SqlDataReader rd = ob.Fn_Reader(pro);
            while (rd.Read())
            {
                txtName.Text = rd["Pro_Name"].ToString();
                txtPrice.Text = rd["Pro_Price"].ToString();
                Image1.ImageUrl = rd["Pro_Image"].ToString();
                txtDesc.Text = rd["Pro_Description"].ToString();
                txtStock.Text = rd["Pro_Stock"].ToString();
                string st = rd["Pro_Status"].ToString();
                string CTgid = rd["CTG_Id"].ToString();
                if (st == "Available")
                {
                    RadioButtonList1.Items[0].Selected = true;

                }
                else
                {
                    RadioButtonList1.Items[1].Selected = true;
                }
                DropDownList1.Items[Convert.ToInt32(CTgid)-1].Selected = true;

            }

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            //if(FileUpload1.FileName!=null)
            //{
               
            //}
          
            string upt = "update Tb_Product set Pro_Name='" + ConvrtQts(txtName.Text) + "', Pro_Price=" + txtPrice.Text + ",Pro_Description='" + ConvrtQts(txtDesc.Text) + "',Pro_Status='" + RadioButtonList1.SelectedItem.Text + "',Pro_Stock='" + txtStock.Text + "',";

            if (FileUpload1.FileName !="")
            {
                string img = "~/PH/" + FileUpload1.FileName;
                FileUpload1.SaveAs(MapPath(img));
                upt = upt+ "Pro_Image='" + img + "',";
            }
            upt = upt + " CTG_Id=" + DropDownList1.SelectedItem.Value + " where Pro_Id=" + Session["Pid"]+""; 
            
           
            int chkupt = ob.Fn_Nonquery(upt);
            if (chkupt == 1)
            {
                Fn_GdView();
                Fn_View();
                lblSts.Text = "Product Updated ";

            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            {
                Response.Redirect("AdminHomePage.aspx");
            }
        }
    }
}