using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project3.PharmacistUC
{
    public partial class UC_P_SellMedicine : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        public UC_P_SellMedicine()
        {
            InitializeComponent();
        }

        private void UC_P_SellMedicine_Load(object sender, EventArgs e)
        {
            listBoxMed.Items.Clear();
            query = "select mname from medic where eDate>=NOW() and quantity >'0'";
            ds = fn.getData(query);
            for(int i = 0; i < ds.Tables[0].Rows.Count;i++)
            {
                listBoxMed.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_SellMedicine_Load(this, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMed.Items.Clear();
            query = "select mname from medic where mname like'" + txtSearch.Text + "%' and eDate>=NOW() and quantity>'0'";
            ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMed.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUnit.Clear();
            string name = listBoxMed.GetItemText(listBoxMed.SelectedItem);
            txtMedName.Text = name;
            query = "select mid,eDate,perunit from medic where mname='" + name + "'";
            ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtMedID.Text = ds.Tables[0].Rows[0][0].ToString();
                txtExpireDate.Text = ds.Tables[0].Rows[0][1].ToString();
                txtPrice.Text = ds.Tables[0].Rows[0][2].ToString();
            }
            else
            {
                MessageBox.Show("No data found for the selected medicine.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMedID.Clear();
                txtExpireDate.ResetText();
                txtPrice.Clear();
            }
        }

        private void txtUnit_TextChanged(object sender, EventArgs e)
        {
            if(txtUnit.Text!="")
            {
                Int64 unitprice = Int64.Parse(txtPrice.Text);
                Int64 noOfunit = Int64.Parse(txtUnit.Text);
                Int64 totalAmount = unitprice * noOfunit;
                txtTPrice.Text = totalAmount.ToString();
            }
            else
            {
                txtTPrice.Clear();
            }
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(txtMedID.Text!="")
            {
                query = "select quantity from medic where mid='" + txtMedID.Text + "'";
                ds = fn.getData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                newQuantity = quantity - Int64.Parse(txtUnit.Text);

                if(newQuantity>=0)
                {
                    n = guna2DataGridView1.Rows.Add();
                    guna2DataGridView1.Rows[n].Cells[0].Value = txtMedID.Text;
                    guna2DataGridView1.Rows[n].Cells[1].Value = txtMedName.Text;
                    guna2DataGridView1.Rows[n].Cells[2].Value = txtExpireDate.Text;
                    guna2DataGridView1.Rows[n].Cells[3].Value = txtPrice.Text;
                    guna2DataGridView1.Rows[n].Cells[4].Value = txtUnit.Text;
                    guna2DataGridView1.Rows[n].Cells[5].Value = txtTPrice.Text;

                    totalAmount = totalAmount + int.Parse(txtTPrice.Text);
                    Totallabel.Text = "Rs. " + totalAmount.ToString();

                    query = "update medic set quantity='" + newQuantity + "'where mid='" + txtMedID.Text + "'";
                    fn.setData(query, "Medicine Added.");

                }
                else
                {
                    MessageBox.Show("Medicine is out of Stock.\n Only " + quantity + " Left", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                clearAll();
                UC_P_SellMedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select Medicine first.", "information!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int valueAMount;
        string valueID;
        protected Int64 noOfunit;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                valueAMount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueID = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfunit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception)
            {

            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(valueID))
            {
                try
                {
                    // Ensure there's a selected row to remove
                    if (guna2DataGridView1.SelectedRows.Count > 0)
                    {
                        guna2DataGridView1.Rows.RemoveAt(guna2DataGridView1.SelectedRows[0].Index);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Get current quantity from DB
                    query = "select quantity from medic where mid='" + valueID + "'";
                    ds = fn.getData(query);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                        newQuantity = quantity + noOfunit;

                        query = "update medic set quantity='" + newQuantity + "' where mid='" + valueID + "'";
                        fn.setData(query, "Medicine Removed from Cart");

                        totalAmount = totalAmount - valueAMount;
                        Totallabel.Text = "Rs. " + totalAmount.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Could not find medicine to restore quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                UC_P_SellMedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("Please select a medicine to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clearAll()
        {
            txtMedID.Clear();
            txtMedName.Clear();
            txtMedID.ResetText();
            txtPrice.Clear();
            txtUnit.Clear();
            txtTPrice.Clear();
        }
    }
}
