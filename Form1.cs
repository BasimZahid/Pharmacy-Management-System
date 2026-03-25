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
    public partial class Form1 : Form
    {
        function fn = new function();
        string query;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void btnsignin_Click(object sender, EventArgs e)
        {
            query = "select * from Users";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count==0)
            {
                if(txtusername.Text=="root" && txtpassword.Text=="root")
                {
                    Administrator admin = new Administrator();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query="select * from Users where username ='"+txtusername.Text+"'and pass ='"+txtpassword.Text+"'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count!=0)
                {
                    string role = ds.Tables[0].Rows[0][1].ToString();
                    if (role == "Administrator")
                    {
                        Administrator admin = new Administrator(txtusername.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if (role == "Pharmacist") 
                    {
                        Pharmacist pharm = new Pharmacist();
                        pharm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username or passwaord", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //if (txtusername.Text == "azan" && txtpassword.Text == "123")
            //{
                //Administrator am = new Administrator();
                //am.Show();
                //this.Hide();
            //}
            //else
            //{
              //  MessageBox.Show("Wrong username or passwaord", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
