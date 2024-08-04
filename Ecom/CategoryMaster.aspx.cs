using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecom
{
    public partial class CategoryMaster : System.Web.UI.Page
    {
        ConnectionCls ob = new ConnectionCls();
        public string ConvrtQts(string str)
        {
            return str.Replace("'", "''");
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string img = "~/PH/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(img));

            string ins = "insert into Tb_Category values('" + ConvrtQts(txtName.Text) + "','" + img + "','" + ConvrtQts(txtDesc.Text) + "','" +rbStatus.SelectedItem.Text + "')";
            int i = ob.Fn_Nonquery(ins);
            if (i == 1)
            {
                lblSts.Visible = true;
                lblSts.Text = "Category created successfully";
                //if( txtName.Focus())
                //{

                //}
                txtName.Text = "";
                txtDesc.Text = "";
             
                

            }
        }
    }
}