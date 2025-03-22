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
using MidProjectDb.BL.MidProjectDb.BL;

namespace MidProjectDb.UI
{
    public partial class Reports: Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DepartmentHead head = new DepartmentHead();
            head.Size = this.Size;
            head.Location = this.Location;
            head.Show();
            this.Close();
        }

        private void Assignworkload_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = CourseSechdule.report();
            ReportGenerator.Instance.ExportDataTableToPDF(dt, $"Faculty Course Schedule Report");
        }

        private void Adminduty_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = Facultyadmin.report();
            ReportGenerator.Instance.ExportDataTableToPDF(dt, $"Faculty Admin Duties Report");

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DataTable dt = Facultyproject.report();
            ReportGenerator.Instance.ExportDataTableToPDF(dt, $"Faculty Project Report");
        }
    }
}
