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
            try
            {
                if (Instructor_comboBox.SelectedIndex != -1 && Courses_combobox.SelectedIndex != -1 && Sem_combobox.SelectedIndex != -1)
                {
                    int Instructorid = Convert.ToInt32(Instructor_comboBox.SelectedValue);
                    int coursesid = Convert.ToInt32(Courses_combobox.SelectedValue);
                    int semid = Convert.ToInt32(Sem_combobox.SelectedValue);
                    Faculty f = Faculty.findFaculty(Instructorid);
                    Course c = Course.findCourse(coursesid);
                    Semester s = Semester.finSem(semid);
                    Facultycourse facultycourse = new Facultycourse(Instructorid, coursesid, semid, c, f, s);
                    if (Facultycourse.addFacultyCourse(facultycourse))
                    {
                        Instructor_comboBox.SelectedIndex = -1;
                        Courses_combobox.SelectedIndex = -1;
                        Sem_combobox.SelectedIndex = -1;
                        MessageBox.Show($"Course assigned to {f.Name} successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Either the instructor is already teaching same course or instructor does not have enough available hours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Please select all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDatagrid();
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
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["faculty_course_id"].ReadOnly = true;
                dataGridView1.Columns["faculty_id"].Visible = false;
                dataGridView1.Columns["course_id"].Visible = false; 
                dataGridView1.Columns["oldfaculty_id"].Visible = false;
                dataGridView1.Columns["oldcourse_id"].Visible = false;
                dataGridView1.Columns["semester_id"].Visible = false;
                addFacultyDropdowns();
                addCourseDropdowns();
                addSemDropdowns();
                loadComboBoxes();
                foreach(DataRow dr in dt.Rows)
                {
                    int id =Convert.ToInt32(dr["faculty_id"]);
                    Faculty f = Faculty.findFaculty(id);
                    if (f.TotalTeachingHours < 0)
                    {
                        MessageBox.Show($"{f.Name } is assigned more hours than available time due to changing of contact hours of courses", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void addCourseDropdowns()
        {
            if (dataGridView1.Columns["Course"] != null)
            {
                dataGridView1.Columns.Remove("Course");
            }
            DataTable courseTable = Course.getTable(); 
            foreach (DataRow row in courseTable.Rows)
            {
                Course c = Course.findCourse(Convert.ToInt32(row["course_id"]));
                row["course_name"] = $"{c.CourseName}-{c.ContactHours} hours";
            }
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Name = "Course";
            comboBoxColumn.HeaderText = "Course";
            comboBoxColumn.DataSource = courseTable;  
            comboBoxColumn.DisplayMember = "course_name";
            comboBoxColumn.ValueMember = "course_id";
            comboBoxColumn.DataPropertyName = "course_id";  
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

        private void update_btn_Click(object sender, EventArgs e)
        {
            try 
            {
                if (dataGridView1.DataSource != null)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int facultycourseid = Convert.ToInt32(row.Cells["faculty_course_id"].Value);
                        int oldfacultyid = Convert.ToInt32(row.Cells["oldfaculty_id"].Value);
                        int oldCourseid = Convert.ToInt32(row.Cells["oldcourse_id"].Value);
                        int semid = Convert.ToInt32(row.Cells["Semester"].Value);
                        int newfaculty = Convert.ToInt32(row.Cells["Faculty"].Value);
                        int newcourse = Convert.ToInt32(row.Cells["Course"].Value);
                        Faculty f = Faculty.findFaculty(newfaculty);
                        Course c = Course.findCourse(newcourse);
                        Semester s = Semester.finSem(semid);
                        Facultycourse fc = new Facultycourse(facultycourseid,f.FacultyId, c.CourseId, semid, c, f, s);
                        if (!Facultycourse.updatefacultycourse(fc, oldCourseid, oldfacultyid))
                        {
                            MessageBox.Show($"Either the instructor {f.Name} is already teaching same course or instructor does not have enough available hours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete selected records?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                        {
                            int Id = Convert.ToInt32(dr.Cells["faculty_course_id"].Value);
                            Facultycourse.DeleteFaccourse(Id);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
