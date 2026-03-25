using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project3
{
    public partial class Administrator : Form
    {
        string user="";
        public Administrator()
        {
            InitializeComponent();
        }
        public Administrator(string username)
        {
            InitializeComponent();
            usernameLabel.Text = username;
            user = username;
            uC_Viewuser1.ID = ID;
            uC_Profile1.ID = ID;
        }
        public string ID
        {
            get { return user.ToString(); }
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_Adduser1.Visible = false;
            uC_Viewuser1.Visible = false;
            uC_Profile1.Visible = false;
            btn_Dashboard.PerformClick();
        }

        private void btnAdduser_Click(object sender, EventArgs e)
        {
            uC_Adduser1.Visible = true;
            uC_Adduser1.BringToFront();
        }

        private void btnViewuser_Click(object sender, EventArgs e)
        {
            uC_Viewuser1.Visible = true;
            uC_Viewuser1.BringToFront();
        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            uC_Profile1.Visible = true;
            uC_Profile1.BringToFront();
        }



        //private void guna2Button1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
