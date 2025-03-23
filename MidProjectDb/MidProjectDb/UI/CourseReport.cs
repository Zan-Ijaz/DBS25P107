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
    public partial class CourseReport: Form
    {
        public CourseReport()
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
            DataTable dt = CourseSechdule.report();
            ReportGenerator.Instance.ExportDataTableToPDF("CourseScheduleReport", "CourseScheduleDataSet", dt);

        }

        private void CourseReport_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void loadDatagrid()
        {
            DataTable dt = CourseSechdule.report();
            dataGridView1.DataSource = dt;
        }
    }
}
