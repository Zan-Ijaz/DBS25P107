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
            CourseReport reports = new CourseReport();
            reports.Size = this.Size;
            reports.Location = this.Location;
            reports.Show();
            this.Close();
            
        }

        private void Adminduty_btn_Click(object sender, EventArgs e)
        {
            AdminDutiesReport reports = new AdminDutiesReport();
            reports.Size = this.Size;
            reports.Location = this.Location;
            reports.Show();
            this.Close();

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ProjectReport reports = new ProjectReport();
            reports.Size = this.Size;
            reports.Location = this.Location;
            reports.Show();
            this.Close();
        }
    }
}
