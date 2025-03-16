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
    public partial class ResearchSuper: Form
    {
        public ResearchSuper()
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

        private void Assign_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void ResearchSuper_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void loadDatagrid()
        {
            try
            {
                DataTable dt = Facultyproject.DataGridTable();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["faculty_project_id"].ReadOnly = true;
                dataGridView1.Columns["faculty_id"].Visible = false;
                dataGridView1.Columns["project_id"].Visible = false;
                dataGridView1.Columns["oldfaculty_id"].Visible = false;
                dataGridView1.Columns["oldproject_id"].Visible = false;
                dataGridView1.Columns["semester_id"].Visible = false;
                dataGridView1.Columns["oldhrs"].Visible = false;
                addFacultyDropdowns();
                addProjectDropdowns();
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
            foreach (DataRow row in facultyTable.Rows)
            {
                Faculty f = Faculty.findFaculty(Convert.ToInt32(row["faculty_id"]));
                row["name"] = $"{f.Name}-{f.TotalTeachingHours} hours";
            }
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
                Semester s = Semester.finSem(Convert.ToInt32(row["semester_id"]));
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
        private void addProjectDropdowns()
        {
            if (dataGridView1.Columns["Project"] != null)
            {
                dataGridView1.Columns.Remove("Project");
            }
            DataTable projectTable = Project.GetTable();
            foreach (DataRow row in projectTable.Rows)
            {
                Project p = Project.findProject(Convert.ToInt32(row["project_id"]));
            }
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Name = "Project";
            comboBoxColumn.HeaderText = "Project";
            comboBoxColumn.DataSource = projectTable;
            comboBoxColumn.DisplayMember = "title";
            comboBoxColumn.ValueMember = "project_id";
            comboBoxColumn.DataPropertyName = "project_id";
            dataGridView1.Columns.Add(comboBoxColumn);
        }
        private void loadComboBoxes()
        {
            DataTable instructors = Faculty.GetTable();
            if (instructors != null && instructors.Rows.Count > 0)
            {
                foreach (DataRow row in instructors.Rows)
                {
                    row["name"] = $"{row["name"]} - {row["total_teaching_hours"]} hours";
                }
                faculty_comboBox.DataSource = instructors;
                faculty_comboBox.DisplayMember = "name";
                faculty_comboBox.ValueMember = "faculty_id";
            }
            DataTable project = Project.GetTable();
            if (project != null && project.Rows.Count > 0)
            {
               
                project_comboBox.DataSource = project;
                project_comboBox.DisplayMember = "title";
                project_comboBox.ValueMember = "project_id";
            }
            DataTable Semesters = Semester.GetTable();
            if (Semesters != null && Semesters.Rows.Count > 0)
            {
                foreach (DataRow row in Semesters.Rows)
                {
                    row["term"] = $"{row["term"]}  {row["year"]}";
                }
                Semester_comboBox.DataSource = Semesters;
                Semester_comboBox.DisplayMember = "term";
                Semester_comboBox.ValueMember = "semester_id";
            }
            faculty_comboBox.SelectedIndex = -1;
            project_comboBox.SelectedIndex = -1;
            Semester_comboBox.SelectedIndex = -1;

        }
    }
}
