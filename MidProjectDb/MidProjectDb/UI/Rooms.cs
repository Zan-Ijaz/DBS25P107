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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            AdministrativeStaff admin = new AdministrativeStaff();
            admin.Show();
            admin.Size = this.Size;
            admin.Location = this.Location;
            this.Close();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void loadDatagrid()
        {
            try
            {
                dataGridView1.DataSource = null;
                DataTable dt = Room.GetTable();
                if (dt != null)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["room_id"].ReadOnly = true;
                    AddTypeDropdown();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddTypeDropdown()
        {
            if (dataGridView1.Columns["room_id"] != null)
            {
                dataGridView1.Columns["room_type"].Visible = false;
            }
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.DataPropertyName = "room_type";
            comboBoxColumn.HeaderText = "room_type";
            comboBoxColumn.Items.Add("Classroom");
            comboBoxColumn.Items.Add("Lab");
            dataGridView1.Columns.Add(comboBoxColumn);
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            int capacity = 0; string type = "";
            string name = name_txtbox.Text;
            if (Utility.Utility.intValidatioin(capacity_txtbox.Text))
            {
                capacity = Convert.ToInt32(capacity_txtbox.Text);
            }
            else
            {
                MessageBox.Show("Enter valid number for capacity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                capacity_txtbox.Text = "";
            }
            if (comboBox1.SelectedIndex != -1)
            {
                type = comboBox1.SelectedItem?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Room Type not Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox1.SelectedIndex = -1;
            }
            Room r = new Room(name, type, capacity);
            if (Room.add(r))
            {
                MessageBox.Show("Room added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid input or Room name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDatagrid();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                try
                {
                    DataTable dt = (DataTable)dataGridView1.DataSource;
                    foreach (DataRow dr in dt.Rows)
                    {
                        int capacity = 0;
                        int id = Convert.ToInt32(dr["room_id"]);
                        string name = dr["room_name"].ToString();
                        string type = dr["room_type"].ToString();
                        if (Utility.Utility.intValidatioin(dr["capacity"].ToString()))
                        {
                            capacity = Convert.ToInt32(dr["capacity"]);
                        }
                        Room r = new Room(id, name, type, capacity);
                        if (!Room.update(r))
                        {
                            MessageBox.Show("Invalid input or Room with same name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loadDatagrid();
            }
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
                            int Id = Convert.ToInt32(dr.Cells["room_id"].Value);

                            Room.Delete(Id);
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
    }
}
