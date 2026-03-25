using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project3.AdministratorUC
{
    public partial class UC_Profile : UserControl
    {
        function fn = new function();
        string query;
        public UC_Profile()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { usernamelabel.Text = value; }
        }

        private void UC_Profile_Enter(object sender, EventArgs e)
        {
            query = "select * from Users where username ='" + usernamelabel.Text + "'";
            DataSet ds = fn.getData(query);
            txtUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtname.Text = ds.Tables[0].Rows[0][2].ToString();
            txtdob.Text = ds.Tables[0].Rows[0][3].ToString();
            txtmobile.Text = ds.Tables[0].Rows[0][4].ToString();
            txtemail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtpassword.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UC_Profile_Enter(this, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string role = txtUserRole.Text;
            string name = txtname.Text;
            string dob = txtdob.Text;
            Int64 mobile = Int64.Parse(txtmobile.Text);
            string email = txtemail.Text;
            string username = usernamelabel.Text;
            string pass = txtpassword.Text;
            string dobformated = Convert.ToDateTime(dob).ToString("yyyy-MM-dd");

            query = "update Users set userRole ='" + role + "',name='" + name + "',dob='" + dobformated + "',mobile='" + mobile + "',email='" + email + "',pass='" + pass + "'where username='" + username + "'";
            fn.setData(query, "Profle Updation Successfull.");
        }
    }
}
