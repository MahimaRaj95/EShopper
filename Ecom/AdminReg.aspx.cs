using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecom
{
    public partial class AdminReg : System.Web.UI.Page
    {
        ConnectionCls ob = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            string sel = "select max(Reg_Id) from Tb_Login";
            string regid = ob.Fn_Scalar(sel);


            int reg_id = 0;
            if (regid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reg_id = newregid + 1;
            }
            string ins = "insert into TbAdmin_Reg values(" + reg_id + ",'" + txtName.Text + "','" + txtAdr.Text + "','" + txtPhon.Text + "','" + txtEmail.Text + "','active')";
            int i = ob.Fn_Nonquery(ins);
            if (i == 1)
            {
                Label12.Visible = true;
                Label12.Text = "Successfully Registered";
                string inslog = "insert into Tb_Login values(" + reg_id + ",'" + txtUN.Text + "','" + txtPW.Text + "','admin')";
                int a = ob.Fn_Nonquery(inslog);
            }

        }
    }
}