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
    public partial class ManageProducts: Form
    {
        public ManageProducts()
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
            string title = title_txtbox.Text;
            string description = descry_txtbox.Text;
            Project p = new Project(title, description);
            if (Project.addProject(p))
            {
                MessageBox.Show("Project added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                title_txtbox.Text="";
                descry_txtbox.Text="";
            }
            else
            {
                MessageBox.Show("Title already exists or Invalid String  added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDatagrid();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            DataTable dt=new DataTable();
            if (dataGridView1.DataSource != null)
            {
                dt = (DataTable)dataGridView1.DataSource;
                foreach (DataRow row in dt.Rows)
                {
                    int id = Convert.ToInt32(row["project_id"]);
                    string title = row["title"].ToString(); 
                    string description = row["description"].ToString();
                    Project p = new Project(id, title, description);
                    Project.Updateproject(p);
                }
                loadDatagrid();
            }
        }
        private void loadDatagrid()
        {
            try
            {
                dataGridView1.DataSource = null;
                DataTable dt = Project.GetTable();
                if (dt != null)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["project_id"].ReadOnly = true;
                    dataGridView1.Columns["description"].Width = 300;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            loadDatagrid();
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
                            int projectid = Convert.ToInt32(dr.Cells["project_id"].Value);
                            Project.deleteProject(projectid);
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
