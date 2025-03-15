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
    public partial class CourseAllocationfirst: Form
    {
        public CourseAllocationfirst()
        {
            InitializeComponent();
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            WorkLoad work = new WorkLoad();
            work.Show();
            work.Size = this.Size;
            work.Location = this.Location;
            this.Close();

        }

        private void CourseAllocationfirst_Load(object sender, EventArgs e)
        {
            loadComboBoxes();
            loadDatagrid();
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
                Instructor_comboBox.DataSource = instructors;
                Instructor_comboBox.DisplayMember = "name"; 
                Instructor_comboBox.ValueMember = "faculty_id";
            }
            DataTable Courses = Course.getTable();
            if (Courses != null && Courses.Rows.Count > 0)
            {
                foreach (DataRow row in Courses.Rows)
                {
                    row["course_name"] = $"{row["course_name"]} - {row["contact_hours"]} hrs";
                }
                Courses_combobox.DataSource = Courses;
                Courses_combobox.DisplayMember = "course_name";
                Courses_combobox.ValueMember = "course_id";
            }
            DataTable Semesters = Semester.GetTable();
            if (Semesters != null && Semesters.Rows.Count > 0)
            {
                foreach (DataRow row in Semesters.Rows)
                {
                    row["term"] = $"{row["term"]}  {row["year"]}";
                }
                Sem_combobox.DataSource = Semesters;
                Sem_combobox.DisplayMember = "term";
                Sem_combobox.ValueMember = "semester_id";
            }
            Instructor_comboBox.SelectedIndex = -1;
            Courses_combobox.SelectedIndex = -1;
            Sem_combobox.SelectedIndex = -1;

        }
        private void loadDatagrid()
        {
            try
            {
                DataTable dt = Facultycourse.DatagridTable();
                if (dt != null)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["faculty_course_id"].ReadOnly = true;
                    dataGridView1.Columns["faculty_id"].Visible = false;
                    dataGridView1.Columns["course_id"].Visible = false;
                    dataGridView1.Columns["semester_id"].Visible = false;
                    //AddDesignationDropdown();
                    //AddRoleDropdown();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addFacultyDropdown()
        {
            if (dataGridView1.Columns["Faculty"] != null)
            {
                dataGridView1.Columns["Faculty"].Visible = false;
            }
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.DataPropertyName = "Faculty";
            comboBoxColumn.HeaderText = "Faculty";
            DataTable 
            comboBoxColumn.Items.Add("Professor");
            comboBoxColumn.Items.Add("Lecturer");
            comboBoxColumn.Items.Add("Assistant Professor");
            comboBoxColumn.Items.Add("Associate Professor");
            dataGridView1.Columns.Add(comboBoxColumn);
        }
    }
}
