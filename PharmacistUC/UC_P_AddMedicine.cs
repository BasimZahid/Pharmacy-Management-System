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
    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        string query;
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if(txtMedID.Text!="" && txtMedname.Text != "" && txtMednum.Text != "" && txtquantity.Text != "" && txtpriceunit.Text != "")
            {
                string mid = txtMedID.Text;
                string mname = txtMedname.Text;
                string mnumber = txtMednum.Text;
                string mdate = txtManuDate.Text;
                string edate = txtexpirdate.Text;
                Int64 quantity = Int64.Parse(txtquantity.Text);
                Int64 perunit = Int64.Parse(txtpriceunit.Text);
                string mdateformated = Convert.ToDateTime(mdate).ToString("yyyy-MM-dd");
                string edateformated = Convert.ToDateTime(edate).ToString("yyyy-MM-dd");

                query = "insert into medic (mid,mname,mnumber,mDate,eDate,quantity,perUnit) values ('" + mid + "','" + mname + "','" + mnumber + "','" + mdateformated + "','" + edateformated + "'," + quantity + "," + perunit + ")";
                fn.setData(query, "Medicine Added Successfully");
            }
            else
            {
                MessageBox.Show("Enter all Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            txtMedID.Clear();
            txtMedname.Clear();
            txtMednum.Clear();
            txtManuDate.ResetText();
            txtexpirdate.ResetText();
            txtquantity.Clear();
            txtpriceunit.Clear();
        }
    }
}
