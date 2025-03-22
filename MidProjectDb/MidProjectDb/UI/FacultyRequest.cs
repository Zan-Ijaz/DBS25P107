using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidProjectDb.BL;
using MidProjectDb.BL.MidProjectDb.BL;
using Org.BouncyCastle.Ocsp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MidProjectDb.UI
{
    public partial class FacultyRequest: Form
    {
        public FacultyRequest()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            Faculty_Members faculty = new Faculty_Members();
            faculty.Show();
            faculty.Size = this.Size;
            faculty.Location = this.Location;
            this.Close();
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(itemname_comboBox.SelectedValue);
            int quantity = 0;
            if (Utility.Utility.intValidatioin(Quantity_txtbox.Text.ToString()))
            {
                quantity = Convert.ToInt32(Quantity_txtbox.Text);
            }
            else
            {
                MessageBox.Show("Enter valid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DateTime currentDate = DateTime.Now;
            string email = LoggedInUser.LoggedUser["email"].ToString();
            Faculty f = Faculty.findFaculty(email);
            Consumable c = Consumable.findconsumable(itemId);
            Lookup status = Lookup.findlookup(8);
            if(itemname_comboBox.SelectedIndex!=-1)
            {
                FacultyReq fr = new FacultyReq(f.FacultyId, 8, itemId, quantity, currentDate, f, c, status);//setting satus pending
                if (FacultyReq.add(fr))
                {
                    MessageBox.Show("Request made successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Quantity_txtbox.Text = "";
                }
                else
                {
                    MessageBox.Show("You cannot make same request again or enter valid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDatagrid();
        }
        private void FacultyRequest_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void loadDatagrid()
        {
            try
            {
                List<FacultyReq> requests = FacultyReq.GetData();
                dataGridView1.DataSource = null;
                List<FacultyReq> filteredRequests = requests.Where(req => req.facultymember.UserId == Convert.ToInt32(LoggedInUser.LoggedUser["user_id"])&& req.status.lookupid == 8).ToList();
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
                addItemDropdowns();
                loadComboboxes();
            }
            catch(Exception ex)
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
        private void loadComboboxes()
        {
            List<Consumable> consumabels = Consumable.getList();
            if (consumabels != null)
            {
                itemname_comboBox.DataSource = consumabels;
                itemname_comboBox.DisplayMember = "ItemName";
                itemname_comboBox.ValueMember = "ConsumableId";
            }
            itemname_comboBox.SelectedIndex = -1;
        }
        private void addItemDropdowns()
        {
            if (dataGridView1.Columns["item"] != null)
            {
                dataGridView1.Columns.Remove("item");
            }
            List<Consumable> items = Consumable.getList();
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Name = "item";
            comboBoxColumn.HeaderText = "Item";
            comboBoxColumn.DataSource = items;
            comboBoxColumn.DisplayMember = "ItemName";
            comboBoxColumn.ValueMember = "ConsumableId";
            comboBoxColumn.DataPropertyName = "itemid"; 
            dataGridView1.Columns.Add(comboBoxColumn);
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow();
        }
        private void DeleteSelectedRow()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete Selected records?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                        {
                            int Id = Convert.ToInt32(dr.Cells["requesid"].Value);
                            FacultyReq.delete(Id);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDatagrid();

        }
        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow Row in dataGridView1.Rows)
                {
                    int requestid = Convert.ToInt32(Row.Cells["requestid"].Value);
                    DateTime date = Convert.ToDateTime(Row.Cells["request_date"].Value);
                    int statusid = Convert.ToInt32(Row.Cells["statusid"].Value);
                    int item= Convert.ToInt32(Row.Cells["item"].Value);
                    Lookup status = Lookup.findlookup(statusid);
                    int facultyid = Convert.ToInt32(Row.Cells["facultyid"].Value);
                    Faculty f = Faculty.findFaculty(facultyid);
                    int quantity = 0;
                    if (Utility.Utility.intValidatioin(Row.Cells["quantity"].Value.ToString()))
                    {
                        quantity= Convert.ToInt32(Row.Cells["quantity"].Value);
                    }
                    Consumable c = Consumable.findconsumable(item);
                    FacultyReq fr = new FacultyReq(requestid, facultyid, statusid, c.ConsumableId, quantity, date, f, c, status);
                    if (!FacultyReq.update(fr))
                    {
                        MessageBox.Show($"Failed to update {c.ItemName}'s request", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            loadDatagrid();
        }
    }
}
