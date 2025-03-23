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
    public partial class InventoryReport : Form
    {
        public InventoryReport()
        {
            InitializeComponent();
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
            DataTable dt = Consumable.report();
            ReportGenerator.Instance.ExportDataTableToPDF( $"InventoryReport","Inventory", dt);
        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }
        private void loadDataGrid()
        {
            DataTable dt = Consumable.report();
            dataGridView1.DataSource = dt;
        }
    }
}
