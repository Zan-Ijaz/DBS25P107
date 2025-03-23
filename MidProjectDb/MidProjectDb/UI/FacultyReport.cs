using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProjectDb.UI
{
    public partial class FacultyReport: Form
    {
        public FacultyReport()
        {
            InitializeComponent();
        }

        private void FacultyReport_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void loadDatagrid()
        {
            DataTable dt = Faculty.report();
            dataGridView1.DataSource = dt;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = Faculty.report();
            ReportGenerator.Instance.ExportDataTableToPDF($"FacultyReport", "Faculty", dt);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            AdminReports reports = new AdminReports();
            reports.Size = this.Size;
            reports.Location = this.Location;
            reports.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
