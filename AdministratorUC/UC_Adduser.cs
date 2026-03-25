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
    public partial class UC_Adduser : UserControl
    {
        function fn = new function();
        String query;
        public UC_Adduser()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string role = txtuserrole.Text;
            string name = txtname.Text;
            DateTime dob = txtDOB.Value;
            Int64 mobile = Int64.Parse(txtmobileno.Text);
            string email = txtemailadd.Text;
            string username = txtusername.Text;
            string pass = txtpassword.Text;
            try
            {
                string dobformated = dob.ToString("yyyy-MM-dd");
                query = "INSERT INTO Users(userRole,name,dob,mobile,email,username,pass) values ('" + role + "','" + name + "','" + dobformated + "','" + mobile + "','" + email + "','" + username + "','" + pass + "')";
                fn.setData(query, "Sign Up successful.");
            }
            catch(Exception ex)
            {
                //MessageBox.Show("username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
                MessageBox.Show("Error: " + ex.Message, "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

             }
    }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Clearall();
        }
        public void Clearall()
        {
            txtDOB.ResetText();
            txtemailadd.Clear();
            txtpassword.Clear();
            txtuserrole.SelectedIndex = -1;
            txtusername.Clear();
            txtname.Clear();
            txtmobileno.Clear();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM Users WHERE username='" + txtusername.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count==0)
            {
                pictureBox1.ImageLocation = @"C:\Users\Azan Qamar\Desktop\screenshots\yes.png";
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\Azan Qamar\Desktop\screenshots\cross.png";
            }
        }
    }
}
