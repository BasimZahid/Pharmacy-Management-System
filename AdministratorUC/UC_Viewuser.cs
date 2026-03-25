using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;

namespace project3.AdministratorUC
{
    public partial class UC_Viewuser : UserControl
    {
        function fn = new function();
        string query;
        string currentUser = "";
        public UC_Viewuser()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { currentUser = value; }
        }
        private void UC_Viewuser_Load(object sender, EventArgs e)
        {
            query = "select * from Users";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query="select * from Users where username like '"+txtUserName.Text+"%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        string userName;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (currentUser != userName)
                {
                    query="delete from Users where username='"+userName+"'";
                    fn.setData(query, "User Record Deleted.");
                    UC_Viewuser_Load(this, null);
                }
                else
                {
                    MessageBox.Show("You are trying to delete \n Your own profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_Viewuser_Load(this, null);
        }
    }
}
