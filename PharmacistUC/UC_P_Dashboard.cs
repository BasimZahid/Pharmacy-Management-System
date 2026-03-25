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
    public partial class UC_P_Dashboard : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        Int64 count;
        public UC_P_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_P_Dashboard_Load(object sender, EventArgs e)
        {
            loadchart();
        }
        public void loadchart()
        {
            query = "select count(mname) from medic where eDate>=NOW()";
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Valid Medicine"].Points.AddXY("Medicine Validity Check", count);

            query = "select count(mname) from medic where eDate<=NOW()";
            ds = fn.getData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Expired Medicine"].Points.AddXY("Medicine Validity Check", count);
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            chart1.Series["Valid Medicine"].Points.Clear();
            chart1.Series["Expired Medicine"].Points.Clear();
            loadchart();
        }
    }
}
