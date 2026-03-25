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
    public partial class UC_P_MedicineValidityCheck : UserControl
    {
        function fn = new function();
        string query;
        public UC_P_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void txtcheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtcheck.SelectedIndex==0)
            {
                query = "select * from medic where eDate>=NOW()";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                setlabel.Text = "Valid Medicine";
                setlabel.ForeColor = Color.Black;
            }
            else if (txtcheck.SelectedIndex == 1)
            {
                query = "select * from medic where eDate<=NOW()";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                setlabel.Text = "Expired Medicine";
                setlabel.ForeColor = Color.Red;
            }
            else if (txtcheck.SelectedIndex == 2)
            {
                query = "select * from medic";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
                setlabel.Text = "";
                setlabel.ForeColor = Color.Black;
            }
        }

        private void UC_P_MedicineValidityCheck_Load(object sender, EventArgs e)
        {
            setlabel.Text = "";
        }
    }
}
