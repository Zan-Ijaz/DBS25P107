using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidProjectDb.BL;

namespace MidProjectDb.UI
{
    public partial class UpdateSem: Form
    {
        public UpdateSem()
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

        private void Save_btn_Click(object sender, EventArgs e)
        {
            string type = "";int year = 0;
            if(comboBox1.SelectedIndex!=-1)
            {
               type = comboBox1.SelectedItem?.ToString() ?? "";
            }
            if(Utility.Utility.intValidatioin(year_txtbox.Text))
            {
                year = Convert.ToInt32(year_txtbox.Text);
            }
            Semester s = new Semester(type, year);
            if (Semester.addSem(s))
            {
                MessageBox.Show("Semester Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDatagrid();
        }
        private void UpdateSem_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void loadDatagrid()
        {
            try
            {
                dataGridView1.DataSource = null;
                DataTable dt = Semester.GetTable();
                if (dt != null)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["semester_id"].ReadOnly = true;
                    AddTermDropdown();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void AddTermDropdown()
        {
            if (dataGridView1.Columns["term"] != null)
            {
                dataGridView1.Columns["term"].Visible = false;
            }
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.DataPropertyName = "term";
            comboBoxColumn.HeaderText = "term";
            comboBoxColumn.Items.Add("Spring");
            comboBoxColumn.Items.Add("Summer");
            comboBoxColumn.Items.Add("Fall");
            dataGridView1.Columns.Add(comboBoxColumn);
        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            try 
            {
                DataTable dt = new DataTable();
                if(dataGridView1.DataSource != null) 
                {
                    dt = (DataTable)dataGridView1.DataSource;
                    foreach (DataRow dr in dt.Rows)
                    {
                        string type = ""; int year = 0;
                        int id =Convert.ToInt32( dr["semester_id"]);
                        type = dr["term"].ToString();
                        if (Utility.Utility.intValidatioin(dr["year"].ToString()))
                        {
                            year = Convert.ToInt32(dr["year"]);
                        }
                        Semester s = new Semester(id,type, year);
                        Semester.update(s);
                    }
                }
                loadDatagrid();
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Del_btn_Click(object sender, EventArgs e)
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
                            int Semid = Convert.ToInt32(dr.Cells["semester_id"].Value);
                            Semester.deleteSem(Semid);
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
