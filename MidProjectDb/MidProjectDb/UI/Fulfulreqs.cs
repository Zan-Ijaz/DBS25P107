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
using Org.BouncyCastle.Asn1.Ocsp;

namespace MidProjectDb.UI
{
    public partial class Fulfulreqs : Form
    {
        public Fulfulreqs()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            DepartmentHead depthead = new DepartmentHead();
            depthead.Show();
            depthead.Size = this.Size;
            depthead.Location = this.Location;
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int requesid = Convert.ToInt32(reqid_comboBox.SelectedValue);
            string status = status_comboBox.Text.ToString();
            Lookup s=Lookup.findlookup(status);
            FacultyReq fr = FacultyReq.findReq(requesid);
            fr.statusid = s.lookupid;
            fr.status = s;
            if (FacultyReq.update(fr))
            {
                MessageBox.Show($"Status set to\"{status}\" Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadDatagrid();
        }

        private void Fulfulreqs_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void loadDatagrid()
        {
            try
            {
                List<FacultyReq> requests = FacultyReq.GetData();
                dataGridView1.DataSource = null;
                List<FacultyReq> filteredRequests = requests.Where(req => req.status.lookupid == 8).ToList();

                dataGridView1.DataSource = filteredRequests;

                dataGridView1.Columns["request_date"].HeaderText = "Date and Time";
                dataGridView1.Columns["request_date"].Width = 150;
                dataGridView1.Columns["item"].HeaderText = "Items";
                dataGridView1.Columns["itemid"].Visible = false;
                dataGridView1.Columns["statusid"].Visible = false;
                dataGridView1.Columns["status"].Visible = false;
                dataGridView1.Columns["facultyid"].Visible = false;
                dataGridView1.Columns["facultymember"].Visible = false;
                loadStatus();
                loadItems();
                loadComboboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
        private void loadComboboxes()
        {
            List<FacultyReq> facultyReqs = FacultyReq.GetData();
            List<FacultyReq> filteredRequests = facultyReqs.Where(req => req.status.lookupid == 8).ToList();

            if (facultyReqs != null)
            {
                reqid_comboBox.DataSource = filteredRequests;
                reqid_comboBox.DisplayMember = "requestid";
                reqid_comboBox.ValueMember = "requestid";
            }
            
            reqid_comboBox.SelectedIndex = -1;
        }

    }
}
