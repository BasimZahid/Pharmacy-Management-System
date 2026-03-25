using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project3.PharmacistUC
{
    public partial class UC_P_ViewMedicine : UserControl
    {
        function fn = new function();
        string query;
        public UC_P_ViewMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_ViewMedicine_Load(object sender, EventArgs e)
        {
            query = "select * from medic";
            setDataGridView(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from medic where mname like '" + txtSearch.Text + "%'";
            setDataGridView(query);
        }
        public void setDataGridView(string query)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        string medicineID;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                medicineID = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(); 
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure?","Delete Confirmation!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                query = "delete from medic where mid='" + medicineID + "'";
                fn.setData(query, "Medicine record deleted");
                UC_P_ViewMedicine_Load(this, null);
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_ViewMedicine_Load(this, null);
        }
    }
}
