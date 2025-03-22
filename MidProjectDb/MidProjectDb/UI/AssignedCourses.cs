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
    public partial class AssignedCourses: Form
    {
        public AssignedCourses()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            int role = Convert.ToInt32(LoggedInUser.LoggedUser["role_id"]);
            if (role == 2)
            {
                Faculty_Members fac = new Faculty_Members();
                fac.Show();
                fac.Size = this.Size;
                fac.Location = this.Location;
                this.Close();
            }
            if (role == 3)
            {
                DepartmentHead head = new DepartmentHead();
                head.Size = this.Size;
                head.Location = this.Location;
                head.Show();
                this.Close();
            }
        }

        private void AssignedCourses_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void loadDatagrid()
        {
            DataRow dr = LoggedInUser.LoggedUser;
            string email = dr["email"].ToString();
            Faculty f = Faculty.findFaculty(email);
            var formattedSchedule = CourseSechdule.getData()
                .Where(c => c.facultycourse.facultyid == f.FacultyId)
                .Select(c => new
                {
                    SechduleId = c.Sechduleid,
                    CourseName = c.facultycourse.course.CourseName,
                    Semester = $"{c.facultycourse.Semester.Term} {c.facultycourse.Semester.Year}",
                    Day = c.day,
                    Starttime = c.starttime,
                    Endtime = c.Endtime
                }).ToList();
            dataGridView1.DataSource = formattedSchedule;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DataRow dr = LoggedInUser.LoggedUser;
            string email = dr["email"].ToString();
            Faculty f = Faculty.findFaculty(email);
            DataTable dt = CourseSechdule.report(f.FacultyId);
            ReportGenerator.Instance.ExportDataTableToPDF(dt, $"{f.Name} Course Schedule Report");
        }
    }
}
