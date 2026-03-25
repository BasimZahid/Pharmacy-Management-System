using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project3.PharmacistUC
{
    public partial class UC_P_ModifyMedicine : UserControl
    {
        function fn = new function();
        string query;
        public UC_P_ModifyMedicine()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtMedID.Text!="")
            {
                query = "select * from medic where mid='" + txtMedID.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count!=0)
                {
                    txtMedName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedNum.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtEDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtAvailQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtPrice.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No Medicine with ID " + txtMedID.Text + " exitst", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }
        }
        private void clearAll()
        {
            txtMedID.Clear();
            txtMedName.Clear();
            txtMedNum.Clear();
            txtMDate.ResetText();
            txtEDate.ResetText();
            txtAvailQuantity.Clear();
            txtPrice.Clear();
            if(txtAddQuantity.Text!="0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        Int64 totalquantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string medname = txtMedName.Text;
            string mednum = txtMedNum.Text;
            string mdate = txtMDate.Text;
            string edate = txtEDate.Text;
            Int64 availquantity = Int64.Parse(txtAvailQuantity.Text);
            Int64 addquantity = Int64.Parse(txtAddQuantity.Text);
            Int64 price = Int64.Parse(txtPrice.Text);
            string mdateformated = Convert.ToDateTime(mdate).ToString("yyyy-MM-dd");
            string edateformated = Convert.ToDateTime(edate).ToString("yyyy-MM-dd");

            totalquantity = availquantity + addquantity;
            query="update medic set mname='"+medname+"',mnumber='"+mednum+"',mDate='"+mdateformated+"',eDate='"+edateformated+"',quantity="+totalquantity+",perUnit="+price+" where mid='"+txtMedID.Text+"'";
            fn.setData(query, "Details Updated Successfully");

        }
    }
}
