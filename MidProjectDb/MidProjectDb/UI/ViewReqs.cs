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
    public partial class ViewReqs: Form
    {
        public ViewReqs()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            Faculty_Members fac = new Faculty_Members();
            fac.Show();
            fac.Size = this.Size;
            fac.Location = this.Location;
            this.Close();
        }
        private void loadDatagrid()
        {
            try
            {
                List<FacultyReq> requests = FacultyReq.GetData();
                dataGridView1.DataSource = null;
                List<FacultyReq> filteredRequests = requests.Where(req => req.facultymember.UserId == Convert.ToInt32(LoggedInUser.LoggedUser["user_id"])).ToList();
                dataGridView1.DataSource = filteredRequests;

                dataGridView1.Columns["requestid"].ReadOnly = true;
                dataGridView1.Columns["Status"].ReadOnly = true;

                dataGridView1.Columns["request_date"].ReadOnly = true;
                dataGridView1.Columns["request_date"].HeaderText = "Date and Time";
                dataGridView1.Columns["request_date"].Width = 150;

                dataGridView1.Columns["itemid"].Visible = false;
                dataGridView1.Columns["statusid"].Visible = false;
                dataGridView1.Columns["status"].Visible = false;
                dataGridView1.Columns["facultyid"].Visible = false;
                dataGridView1.Columns["facultymember"].Visible = false;
                loadStatus();
                loadItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewReqs_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void loadStatus()
        {
            if (!dataGridView1.Columns.Contains("DisplayStatus"))
            {
                DataGridViewTextBoxColumn displayStatusColumn = new DataGridViewTextBoxColumn();
                displayStatusColumn.Name = "DisplayStatus";
                displayStatusColumn.HeaderText = "Status";
                dataGridView1.Columns.Add(displayStatusColumn);
                dataGridView1.Columns["DisplayStatus"].DisplayIndex = 5;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["statusid"].Value != null)
                {
                    int statusid = Convert.ToInt32(row.Cells["statusid"].Value);
                    Lookup status = Lookup.findlookup(statusid);
                    row.Cells["DisplayStatus"].Value = status.value.ToString();
                }
            }
        }
        private void loadItems()
        {
            if (dataGridView1.Columns["item"] != null)
            {
                dataGridView1.Columns["item"].Visible = false;
            }
            if (!dataGridView1.Columns.Contains("DisplayItems"))
            {
                DataGridViewTextBoxColumn displayItemColumn = new DataGridViewTextBoxColumn();
                displayItemColumn.Name = "DisplayItems";
                displayItemColumn.HeaderText = "Items";
                dataGridView1.Columns.Add(displayItemColumn);
                dataGridView1.Columns["DisplayItems"].DisplayIndex = 3;
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["itemid"].Value != null)
                {
                    int itemid = Convert.ToInt32(row.Cells["itemid"].Value);
                    Consumable item = Consumable.findconsumable(itemid);
                    row.Cells["DisplayItems"].Value = item.ItemName.ToString();
                }
            }
        }
    }
}
