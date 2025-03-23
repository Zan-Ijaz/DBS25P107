using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidProjectDb.Properties.DataSources;

namespace MidProjectDb.UI
{
    public partial class RequestSummaryReport: Form
    {
        public RequestSummaryReport()
        {
            InitializeComponent();
        }

        private void RequestSummaryReport_Load(object sender, EventArgs e)
        {
            loadDatagird();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            AdminReports reports = new AdminReports();
            reports.Size = this.Size;
            reports.Location = this.Location;
            reports.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = FacultyReq.report();
            ReportGenerator.Instance.ExportDataTableToPDF($"RequestSummary", "RequestSummary", dt);
        }
        private void loadDatagird()
        {
            DataTable dt = FacultyReq.report();
            dataGridView1.DataSource = dt;
        }
    }
}
