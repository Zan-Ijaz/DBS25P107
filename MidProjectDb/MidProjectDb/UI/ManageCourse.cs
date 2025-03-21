using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MidProjectDb.UI
{
    public partial class ManageCourse: Form
    {
        public ManageCourse()
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

        private void ManageCourse_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void loadDatagrid()
        {
            try
            {
                dataGridView1.DataSource = null;
                DataTable dt = Course.getTable(); 
                if (dt != null)
                {
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["course_id"].ReadOnly = true; 
                    AddCourseTypeDropdown();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            string coursename = "", coursetype = "";
            int creditHour = 0, contacthour = 0;
            if(Utility.Utility.stringvalidation(name_txtbox.Text)&&Course.courseduplication(name_txtbox.Text))
            {
                coursename = name_txtbox.Text;
            }
            else
            {
                if(!Course.courseduplication(name_txtbox.Text))
                {
                    MessageBox.Show("Enter unique title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(!Utility.Utility.stringvalidation(name_txtbox.Text))
                {
                    MessageBox.Show("Enter valid string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                name_txtbox.Text = "";
            }
            if(coursetype_combo.SelectedIndex != -1)
            {
                coursetype = coursetype_combo.SelectedItem?.ToString() ?? "";

            }
            else
            {
                MessageBox.Show("Course Type not Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coursetype_combo.SelectedIndex = -1;
            }
            if (Utility.Utility.intValidatioin(Credithour_txtbox.Text)&&(Convert.ToInt32(Credithour_txtbox.Text)>0|| Convert.ToInt32(Credithour_txtbox.Text)>3))
            {
                creditHour=Convert.ToInt32(Credithour_txtbox.Text);
            }
            else
            {
                MessageBox.Show("Invalid credit hours added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Credithour_txtbox.Text = "";
            }
            if(Utility.Utility.intValidatioin(Contact_txtbox.Text)&&Convert.ToInt32(Contact_txtbox.Text) > 0)
            {
                contacthour = Convert.ToInt32(Contact_txtbox.Text);
            }
            else
            {

                MessageBox.Show("Invalid contact hours added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Contact_txtbox.Text = "";
            }
            if (name_txtbox.Text != "" && coursetype_combo.SelectedIndex != -1 && Contact_txtbox.Text != "" && Credithour_txtbox.Text != "")
            {
                Course course = new Course(coursename, coursetype, creditHour, contacthour);
                Course.insert(course);
                MessageBox.Show("Course added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                name_txtbox.Text = "";
                Contact_txtbox.Text = "";
                Credithour_txtbox.Text = "";
                coursetype_combo.SelectedIndex = -1;
            }
            loadDatagrid();
        }
        private void AddCourseTypeDropdown()
        {
            if (dataGridView1.Columns["course_type"] != null)
            {
                dataGridView1.Columns["course_type"].Visible = false;
            }
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.DataPropertyName = "course_type";
            comboBoxColumn.HeaderText = "course_type";
            comboBoxColumn.Items.Add("Theory");
            comboBoxColumn.Items.Add("Lab");
            dataGridView1.Columns.Add(comboBoxColumn);
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (dataGridView1.DataSource != null)
                {
                    dt = (DataTable)dataGridView1.DataSource;
                    foreach(DataRow row in dt.Rows)
                    {
                        string title = "", type = "";
                        int credit = -1, contact = -1;
                        int courseid = Convert.ToInt32(row["course_id"]);
                        if (Utility.Utility.stringvalidation(row["course_name"].ToString()) && Course.courseduplication(row["course_name"].ToString(), courseid))
                        {
                            title = row["course_name"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Invalid string or course already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        type = row["course_type"].ToString();
                        if (Utility.Utility.intValidatioin(row["credit_hours"].ToString())&& (Convert.ToInt32(row["credit_hours"])>0|| Convert.ToInt32(row["credit_hours"]) < 03))
                        {
                            credit = Convert.ToInt32(row["credit_hours"]);
                        }
                        else
                        {
                            MessageBox.Show("Invalid credit hours added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (Utility.Utility.intValidatioin(row["contact_hours"].ToString())&& Convert.ToInt32(row["contact_hours"])>0)
                        {
                            contact = Convert.ToInt32(row["contact_hours"]);
                        }
                        else
                        {
                            MessageBox.Show("Invalid contact hours added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if(title!=""&&type!=""&&credit!=-1&&contact!=-1)
                        {
                            Course course = new Course(title, type, credit, contact);
                            Course.update(course);
                        }
                        loadDatagrid();
                    }
                }
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
                            int course = Convert.ToInt32(dr.Cells["course_id"].Value);
                            Course.deleteCourse(course);
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
