using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidProjectDb.BL;

namespace MidProjectDb.UI
{
    public partial class AdminDutiesReport: Form
    {
        public AdminDutiesReport()
        {
            InitializeComponent();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Size = this.Size;
            reports.Location = this.Location;
            reports.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = Facultyadmin.report();
            ReportGenerator.Instance.ExportDataTableToPDF($"AdminDutyReport","AdminDuty", dt);
        }

        private void AdminDutiesReport_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }
        private void loadDataGrid()
        {
            DataTable dt = Facultyadmin.report();
            dataGridView1.DataSource = dt;
        }
    }
}
