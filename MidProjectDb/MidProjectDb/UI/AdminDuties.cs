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
using MidProjectDb.BL.MidProjectDb.BL;

namespace MidProjectDb.UI
{
    public partial class AdminDuties: Form
    {
        public AdminDuties()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            WorkLoad work = new WorkLoad();
            work.Show();
            work.Size = this.Size;
            work.Location = this.Location;
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (faculty_comboBox.SelectedIndex != -1 && sem_comboBox.SelectedIndex != -1)
                {
                    int facultyid = Convert.ToInt32(faculty_comboBox.SelectedValue);
                    int semid = Convert.ToInt32(sem_comboBox.SelectedValue);
                    string rolename = rolefacname_txtbox.Text;
                    Faculty f = Faculty.findFaculty(facultyid);
                    Semester s = Semester.findSem(semid);
                    Facultyadmin fa = new Facultyadmin(facultyid,rolename,semid,f,s);
                    if (Facultyadmin.add(fa))
                    {
                        faculty_comboBox.SelectedIndex = -1;
                        sem_comboBox.SelectedIndex = -1;
                        rolefacname_txtbox.Text = "";
                        MessageBox.Show($"{rolename} successfully assigned to {f.Name}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Invalid Input or {rolename} is already assigned to {f.Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Select all values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDatagrid();
        }
        private void loadDatagrid()
        {
            try
            {
                DataTable dt = Facultyadmin.loadGrid();
                if (dt != null)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["admin_role_id"].ReadOnly = true;
                    dataGridView1.Columns["semester_id"].Visible = false;
                    dataGridView1.Columns["faculty_id"].Visible = false;
                    addFacultyDropdowns();
                    addSemDropdowns();
                    loadComboBoxes();
                    foreach (DataRow dr in dt.Rows)
                    {
                        int id = Convert.ToInt32(dr["faculty_id"]);
                        Faculty f = Faculty.findFaculty(id);
                        if (f.TotalTeachingHours < 0)
                        {
                            MessageBox.Show($"{f.Name} is assigned more hours than available time due to changing of contact hours of courses", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addFacultyDropdowns()
        {
            if (dataGridView1.Columns["Faculty"] != null)
            {
                dataGridView1.Columns.Remove("Faculty");
            }
            DataTable facultyTable = Faculty.GetTable();
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Name = "Faculty";
            comboBoxColumn.HeaderText = "Faculty";
            comboBoxColumn.DataSource = facultyTable;
            comboBoxColumn.DisplayMember = "name";
            comboBoxColumn.ValueMember = "faculty_id";
            comboBoxColumn.DataPropertyName = "faculty_id";
            dataGridView1.Columns.Add(comboBoxColumn);
        }
        private void addSemDropdowns()
        {
            if (dataGridView1.Columns["Semester"] != null)
            {
                dataGridView1.Columns.Remove("Semester");
            }
            DataTable semesterTable = Semester.GetTable();
            foreach (DataRow row in semesterTable.Rows)
            {
                Semester s = Semester.findSem(Convert.ToInt32(row["semester_id"]));
                row["term"] = $"{s.Term} {s.Year}";
            }
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Name = "Semester";
            comboBoxColumn.HeaderText = "Semester";
            comboBoxColumn.DataSource = semesterTable;
            comboBoxColumn.DisplayMember = "term";
            comboBoxColumn.ValueMember = "semester_id";
            comboBoxColumn.DataPropertyName = "semester_id";
            dataGridView1.Columns.Add(comboBoxColumn);
        }
        private void loadComboBoxes()
        {
            DataTable instructors = Faculty.GetTable();
            if (instructors != null && instructors.Rows.Count > 0)
            {
                faculty_comboBox.DataSource = instructors;
                faculty_comboBox.DisplayMember = "name";
                faculty_comboBox.ValueMember = "faculty_id";
            }
            DataTable Semesters = Semester.GetTable();
            if (Semesters != null && Semesters.Rows.Count > 0)
            {
                foreach (DataRow row in Semesters.Rows)
                {
                    row["term"] = $"{row["term"]}  {row["year"]}";
                }
                sem_comboBox.DataSource = Semesters;
                sem_comboBox.DisplayMember = "term";
                sem_comboBox.ValueMember = "semester_id";
            }
            faculty_comboBox.SelectedIndex = -1;
            sem_comboBox.SelectedIndex = -1;
        }
        private void AdminDuties_Load(object sender, EventArgs e)
        {
            loadDatagrid();
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
                            int Id = Convert.ToInt32(dr.Cells["admin_role_id"].Value);

                            Facultyadmin.delete(Id);
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
            try
            {
                if (dataGridView1.DataSource != null)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int facultyadminid= Convert.ToInt32(row.Cells["admin_role_id"].Value);
                        int facutyid= Convert.ToInt32(row.Cells["Faculty"].Value);
                        int semid = Convert.ToInt32(row.Cells["Semester"].Value);
                        string rolename = row.Cells["role_name"].Value.ToString();
                        Faculty f = Faculty.findFaculty(facutyid);
                        Semester s = Semester.findSem(semid);
                        Facultyadmin fa = new Facultyadmin(facultyadminid,facutyid,rolename,semid,f,s);
                        if (!Facultyadmin.update(fa))
                        {
                            MessageBox.Show($"Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDatagrid();
        }
    }
}
