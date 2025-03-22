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
using MidProjectDb.DL;

namespace MidProjectDb.UI
{
    public partial class SechdulingCourse2 : Form
    {
        public SechdulingCourse2()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            DepartmentHead head = new DepartmentHead();
            head.Show();
            head.Size = this.Size;
            head.Location = this.Location;
            this.Close();
        }

        private void SechdulingCourse2_Load(object sender, EventArgs e)
        {
            loadDatagrid();
            List<CourseSechdule> courses = CourseSechdule.getData();
            var facultyHours = new Dictionary<int, int>();
            foreach (var c in courses)
            {
                if (!facultyHours.ContainsKey(c.facultycourseid))
                {
                    facultyHours[c.facultycourseid] = 0;
                }
                facultyHours[c.facultycourseid] += (c.Endtime - c.starttime).Hours;
            }
            foreach (var c in courses)
            {
                int totalScheduled = facultyHours[c.facultycourseid];
                int requiredHours = c.facultycourse.course.ContactHours;

                if (totalScheduled < requiredHours)
                {
                    int unscheduled = requiredHours - totalScheduled;
                    MessageBox.Show($"{c.facultycourse.facultymember.Name}-{c.facultycourse.course.CourseName}-{c.facultycourse.Semester.Term} {c.facultycourse.Semester.Year}" +
                        $" has {unscheduled} hours which are not scheduled yet", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        private void loadDatagrid()
        {
            try
            {
                List<CourseSechdule> sechdules = CourseSechdule.getData();
                dataGridView1.DataSource = sechdules;
                dataGridView1.Columns["Sechduleid"].ReadOnly = true;
                dataGridView1.Columns["facultycourse"].Visible = false;
                dataGridView1.Columns["room"].Visible = false;
                dataGridView1.Columns["facultycourseid"].HeaderText = "Faculty Course";
                dataGridView1.Columns["roomid"].HeaderText = "Room";
                loadComboBox();
                loadDropDowns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadComboBox()
        {
            List<Room> rooms = Room.getData();
            if (rooms != null)
            {
                room_comboBox.DataSource = rooms;
                room_comboBox.DisplayMember = "roomname";
                room_comboBox.ValueMember = "roomid";
                room_comboBox.SelectedIndex = -1;
            }
            List<Facultycourse> fcourses = Facultycourse.getList();

            var formattedList = fcourses.Select(fc => new
            {
                facultyCourseid = fc.facultyCourseid,
                DisplayText = $"{fc.facultymember.Name}-{fc.course.CourseName}({fc.course.ContactHours})-{fc.Semester.Term} {fc.Semester.Year}"
            }).ToList();
            if (fcourses != null)
            {
                facultycourse_comboBox.DataSource = formattedList;
                facultycourse_comboBox.ValueMember = "facultyCourseid";
                facultycourse_comboBox.DisplayMember = "DisplayText";
                facultycourse_comboBox.SelectedIndex = -1;
            }
            Startdate.Format = DateTimePickerFormat.Time;
            Startdate.ShowUpDown = true;
            EndDate.Format = DateTimePickerFormat.Time;
            EndDate.ShowUpDown = true;

        }
        private void loadDropDowns()
        {
            if (dataGridView1.Columns["facultycourseid"] != null)
            {
                dataGridView1.Columns.Remove("facultycourseid");
            }
            List<Facultycourse> facultycourse = Facultycourse.getList();
            var formattedList = facultycourse.Select(fc => new
            {
                facultyCourseid = fc.facultyCourseid,
                DisplayText = $"{fc.facultymember.Name}-{fc.course.CourseName}({fc.course.ContactHours})-{fc.Semester.Term} {fc.Semester.Year}"
            }).ToList();
            DataGridViewComboBoxColumn faccoursecomboBox = new DataGridViewComboBoxColumn();
            faccoursecomboBox.Name = "facultycourseid";
            faccoursecomboBox.ValueMember = "facultycourseid";
            faccoursecomboBox.DataPropertyName = "facultycourseid";
            faccoursecomboBox.HeaderText = "Faculty Course";
            faccoursecomboBox.DataSource = formattedList;
            faccoursecomboBox.DisplayMember = "DisplayText";
            dataGridView1.Columns.Add(faccoursecomboBox);
            if (dataGridView1.Columns["roomid"] != null)
            {
                dataGridView1.Columns.Remove("roomid");
            }
            List<Room> rooms = Room.getData();
            DataGridViewComboBoxColumn roomcomboBox = new DataGridViewComboBoxColumn();
            roomcomboBox.Name = "roomid";
            roomcomboBox.ValueMember = "roomid";
            roomcomboBox.DataPropertyName = "roomid";
            roomcomboBox.HeaderText = "Room";
            roomcomboBox.DataSource = rooms;
            roomcomboBox.DisplayMember = "roomname";
            dataGridView1.Columns.Add(roomcomboBox);
            if (dataGridView1.Columns["day"] != null)
            {
                dataGridView1.Columns.Remove("day");
            }
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.Name = "day";
            comboBoxColumn.DataPropertyName = "day";
            comboBoxColumn.HeaderText = "Day";
            comboBoxColumn.Items.AddRange(new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
            dataGridView1.Columns.Add(comboBoxColumn);
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            if (facultycourse_comboBox.SelectedIndex != -1 && room_comboBox.SelectedIndex != -1 && day_comboBox.SelectedIndex != -1)
            {
                int facultycourseid = Convert.ToInt32(facultycourse_comboBox.SelectedValue);
                int roomid = Convert.ToInt32(room_comboBox.SelectedValue);
                string day = day_comboBox.SelectedItem.ToString();
                TimeSpan starttime = Startdate.Value.TimeOfDay;
                TimeSpan endtime = EndDate.Value.TimeOfDay;
                Room r = Room.findroom(roomid);
                Facultycourse fc = Facultycourse.findfacultycourse(facultycourseid);
                CourseSechdule cs = new CourseSechdule(facultycourseid, roomid, fc, r, day, starttime, endtime);
                if (CourseSechdule.addSechdule(cs))
                {
                    MessageBox.Show("Course sechduled successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Either the room or faculty is not free or course has already been sechduled or the course is being sechduled for more than its contact hours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                            int Id = Convert.ToInt32(dr.Cells["Sechduleid"].Value);
                            CourseSechdule.deleteSecdule(Id);
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
                        int sechduleid = Convert.ToInt32(row.Cells["Sechduleid"].Value);
                        int facultycoursid = Convert.ToInt32(row.Cells["facultycourseid"].Value);
                        int roomid = Convert.ToInt32(row.Cells["roomid"].Value);
                        string day = row.Cells["day"].Value.ToString();
                        Room r = Room.findroom(roomid);
                        Facultycourse fc = Facultycourse.findfacultycourse(facultycoursid);
                        if(CourseSechdule.timespan(row.Cells["starttime"].Value.ToString(), row.Cells["Endtime"].Value.ToString()))
                        {
                            TimeSpan startTimeSpan = (TimeSpan)row.Cells["starttime"].Value;
                            TimeSpan endTimeSpan = (TimeSpan)row.Cells["Endtime"].Value;
                            TimeSpan starttime = startTimeSpan;
                            TimeSpan endtime = endTimeSpan;
                            CourseSechdule cs = new CourseSechdule(sechduleid, facultycoursid, roomid, fc, r, day, starttime, endtime);
                            if (!CourseSechdule.updateSechdule(cs))
                            {
                                MessageBox.Show("Either the room or faculty is not free or course has already been sechduled or the course is being sechduled for more than its contact hours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Wrong format of time added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
