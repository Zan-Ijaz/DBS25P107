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
    public partial class Consumeables: Form
    {
        public Consumeables()
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

        private void Consumeables_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            try
            {
                DataTable dt = Consumable.GetTable();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["consumable_id"].ReadOnly = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            string name = itemname_txtbox.Text;
            Consumable c = new Consumable(name);
            if (Consumable.addConsumeable(c))
            {
                MessageBox.Show($"Item added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                itemname_txtbox.Text = "";
            }
            else
            {
                MessageBox.Show($"Invalid Item name added or item name exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDataGrid();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                foreach(DataRow dr in dt.Rows)
                {
                    int id = Convert.ToInt32(dr["consumable_id"]);
                    string name = dr["item_name"].ToString();
                    Consumable c = new Consumable(id, name);
                    if (!Consumable.update(c))
                    {
                        MessageBox.Show($"Invalid Item name added or item name exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
                LoadDataGrid();

        }

        private void Delete_Click(object sender, EventArgs e)
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
                            int Id = Convert.ToInt32(dr.Cells["consumable_id"].Value);

                            Consumable.delete(Id);
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
            LoadDataGrid();

        }
    }
}
