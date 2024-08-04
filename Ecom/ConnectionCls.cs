using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Ecom
{
    public class ConnectionCls
    {
        SqlConnection con;
        SqlCommand cmd;
        public ConnectionCls()
        {

            con = new SqlConnection(@"server=DESKTOP-U97RNPL\SQLEXPRESS;database=Ecommerce;Integrated Security=true");

        }
        public int Fn_Nonquery(string qry)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(qry, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public int Fn_Nonquery_For_Reader(string qry)
        {
            
            cmd = new SqlCommand(qry, con);
           
            int i = cmd.ExecuteNonQuery();
            
            return i;
        }
        public string Fn_Scalar(string qry)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(qry, con);
            con.Open();
            string i = cmd.ExecuteScalar().ToString();
            con.Close();
            return i;
        }
        public SqlDataReader Fn_Reader(string qry)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(qry, con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            return rd;
        }
        public DataSet Fn_Adapter(string qry)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(qry, con);
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter ad = new SqlDataAdapter(qry, con);
            ad.Fill(ds);
            return ds;
        }
        public DataTable Fn_Datatable(string qry)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(qry, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(qry, con);
            ad.Fill(dt);
            return dt;
        }
    }
}