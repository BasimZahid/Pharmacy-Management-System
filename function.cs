using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project3
{
    internal class function
    {
        protected MySqlConnection getConnection()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Server=127.0.0.1;Database=Pharmacy;Uid=root;Pwd=azan123-;integrated security=true";
            return con;
        }
        public DataSet getData(string query)
        {
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(string query,string msg)
        {
            MySqlConnection con = getConnection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
