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
using MidProjectDb.BL;
using Org.BouncyCastle.Asn1.Ocsp;

namespace MidProjectDb.UI
{
    public partial class Requts_Admin_: Form
    {
        public Requts_Admin_()
        {
            InitializeComponent();
        }
        private void loadDatagrid()
        {
            try
            {
                List<FacultyReq> requests = FacultyReq.GetData();
                dataGridView1.DataSource = null;
                List<FacultyReq> filteredRequests = requests.Where(req => req.status.lookupid == 9).ToList();
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
                loadComboboxes();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadComboboxes()
        {
            List<FacultyReq> facultyReqs = FacultyReq.GetData();
            List<FacultyReq> filteredRequests = facultyReqs.Where(req => req.status.lookupid == 9).ToList();

            if (filteredRequests != null)
            {
                reqid_comboBox.DataSource = filteredRequests;
                reqid_comboBox.DisplayMember = "requestid";
                reqid_comboBox.ValueMember = "requestid";
            }

            reqid_comboBox.SelectedIndex = -1;
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

        private void Back_lbl_Click_1(object sender, EventArgs e)
        {
            AdministrativeStaff admin = new AdministrativeStaff();
            admin.Size = this.Size;
            admin.Location = this.Location;
            admin.Show();
            this.Close();
        }

        private void Requts_Admin__Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int requesid = Convert.ToInt32(reqid_comboBox.SelectedValue);
            int statusid = 11;//fulfilled
            Lookup s = Lookup.findlookup(statusid);
            FacultyReq fr = FacultyReq.findReq(requesid);
            fr.statusid = s.lookupid;
            fr.status = s;
            if (FacultyReq.update(fr))
            {
                MessageBox.Show($"Status set to\"{s.value}\" Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            loadDatagrid();
        }
    }
}
