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
            try 
            {
                if (faculty_comboBox.SelectedIndex != -1 && Semester_comboBox.SelectedIndex != -1 && project_comboBox.SelectedIndex != -1)
                {
                    int Instructorid = Convert.ToInt32(faculty_comboBox.SelectedValue);
                    int projectid = Convert.ToInt32(project_comboBox.SelectedValue);
                    int semid = Convert.ToInt32(Semester_comboBox.SelectedValue);
                    int superhrs = 0;
                    Faculty f = Faculty.findFaculty(Instructorid);
                    Project p = Project.findProject(projectid);
                    Semester s = Semester.findSem(semid);
                    if (Utility.Utility.intValidatioin(Supervisionhrs_txtBox.Text))
                    {
                        superhrs = Convert.ToInt32(Supervisionhrs_txtBox.Text);
                    }
                    Facultyproject facultyproject = new Facultyproject(superhrs,Instructorid,projectid,semid,f,s,p);
                    if (Facultyproject.add(facultyproject))
                    {
                        faculty_comboBox.SelectedIndex = -1;
                        project_comboBox.SelectedIndex = -1;
                        Semester_comboBox.SelectedIndex = -1;
                        Supervisionhrs_txtBox.Text = "";
                        MessageBox.Show($"Project assigned to {f.Name} successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Either the instructor is already assigned same project or instructor does not have enough available hours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show($"Please Select all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadDatagrid();
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
                if(dt!=null)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns["faculty_project_id"].ReadOnly = true;
                    dataGridView1.Columns["faculty_id"].Visible = false;
                    dataGridView1.Columns["project_id"].Visible = false;
                    dataGridView1.Columns["oldfaculty_id"].Visible = false;
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

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.DataSource != null)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        int facultyprojectid = Convert.ToInt32(row.Cells["faculty_project_id"].Value);
                        int oldfacultyid = Convert.ToInt32(row.Cells["oldfaculty_id"].Value);
                        int semid = Convert.ToInt32(row.Cells["Semester"].Value);
                        int newfaculty = Convert.ToInt32(row.Cells["Faculty"].Value);
                        int newproject = Convert.ToInt32(row.Cells["Project"].Value);
                        int oldsuperehr= Convert.ToInt32(row.Cells["oldhrs"].Value);
                        int newhrs= Convert.ToInt32(row.Cells["supervision_hours"].Value);
                        Faculty f = Faculty.findFaculty(newfaculty);
                        Project p = Project.findProject(newproject);
                        Semester s = Semester.findSem(semid);
                        Facultyproject fp = new Facultyproject(facultyprojectid,newhrs,f.FacultyId,p.projectId,s.SemesterId,f,s,p);
                        if (!Facultyproject.update(fp,oldfacultyid,oldsuperehr))
                        {
                            MessageBox.Show($"Either the instructor {f.Name} is already assigned to same project or instructor does not have enough available hours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                            int Id = Convert.ToInt32(dr.Cells["faculty_project_id"].Value);
                            Facultyproject.delete(Id);
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
