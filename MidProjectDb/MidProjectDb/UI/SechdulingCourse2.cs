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
    public partial class SechdulingCourse2: Form
    {
        public SechdulingCourse2()
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

        private void SechdulingCourse2_Load(object sender, EventArgs e)
        {
            loadDatagrid();
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
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    CourseSechdule cs = (CourseSechdule)dr.DataBoundItem;
                    dr.Cells["Room"].Value = cs.room.roomname;
                    Facultycourse fc = (Facultycourse)dr.DataBoundItem;
                    dr.Cells["Faculty Course"].Value = $"{fc.facultymember.Name}-{fc.course.CourseName}({fc.course.ContactHours})-{fc.Semester.Term} {fc.Semester.Year}";
                }
                loadComboBox();
            }
            catch(Exception ex)
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
            {
                var formattedList = fcourses.Select(fc => new
                {
                    DisplayText = $"{fc.facultymember.Name}-{fc.course.CourseName}({fc.course.ContactHours})-{fc.Semester.Term} {fc.Semester.Year}"}).ToList();
                if (fcourses != null)
                {
                    facultycourse_comboBox.DataSource = formattedList;
                    facultycourse_comboBox.ValueMember = "facultyCourseid";
                    facultycourse_comboBox.DisplayMember = "DisplayText";
                    facultycourse_comboBox.SelectedIndex = -1;

                }
            }
        }
    }
}
