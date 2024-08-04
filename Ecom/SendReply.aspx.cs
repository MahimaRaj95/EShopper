using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Text;
using System.Data;
using System.Data.SqlClient;



namespace Ecom
{
    public partial class SendReply : System.Web.UI.Page
    {
        ConnectionCls oblog = new ConnectionCls();
        protected void Page_Load(object sender, EventArgs e)
        {
            string MailId="", Username="";
            string GetMailId = "select Email,Name from Tb_User_Reg where User_Reg_Id=" + Session["FeedBackUser"] + "";
            SqlDataReader rd = oblog.Fn_Reader(GetMailId);
            while(rd.Read())
            {
                MailId = rd["Email"].ToString();
                Username= rd["Name"].ToString();
            }
            TextBox1.Text = MailId.ToString();
            TextBox3.Text = "Hi " + Username.ToString();
            Session["Username"] = Username;
            Session["MailId"] = MailId;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SendEmail2("Eshopper-Admin", "rajmahima95@gmail.com", "bsfejlacadizpsqh", Session["Username"].ToString(), Session["MailId"].ToString(), TextBox2.Text, TextBox3.Text);
            string feedbcksts = "update  Tb_Feedback set FeedBack_Status='replied' where User_Id=" + Session["FeedBackUser"] + "";
            int i = oblog.Fn_Nonquery(feedbcksts);
            Label1.Visible = true;
            Label1.Text = "Mail send ";
        }
        public static void SendEmail2(string yourName, string yourGmailUserName, string yourGmailPassword, string toName, string toEmail, string subject, string body)
        {
            string to = toEmail; //To address    
            string from = yourGmailUserName; //From address    
            MailMessage message = new MailMessage(from, to);

            string mailbody = body;
            message.Subject = subject;
            message.Body = mailbody;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
                        System.Net.NetworkCredential(yourGmailUserName, yourGmailPassword);
            client.EnableSsl = true;
            client.UseDefaultCredentials = true;
            client.Credentials = basicCredential1;
            try
            {
                client.Send(message);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}