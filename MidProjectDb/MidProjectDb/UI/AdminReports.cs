using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidProjectDb.BL.MidProjectDb.BL;

namespace MidProjectDb.UI
{
    public partial class AdminReports: Form
    {
        public AdminReports()
        {
            InitializeComponent();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            AdministrativeStaff admin = new AdministrativeStaff();
            admin.Size = this.Size;
            admin.Location = this.Location;
            admin.Show();
            this.Close();
        }

        private void Inventort_btn_Click(object sender, EventArgs e)
        {
            InventoryReport reports = new InventoryReport();
            reports.Size = this.Size;
            reports.Location = this.Location;
            reports.Show();
            this.Close();
        }

        private void req_btn_Click(object sender, EventArgs e)
        {
            RequestSummaryReport reports = new RequestSummaryReport();
            reports.Size = this.Size;
            reports.Location = this.Location;
            reports.Show();
            this.Close();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FacultyReport reports = new FacultyReport();
            reports.Size = this.Size;
            reports.Location = this.Location;
            reports.Show();
            this.Close();
        }
    }
}
