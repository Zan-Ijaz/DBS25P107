using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Ocsp;
using MidProjectDb.BL;
namespace MidProjectDb.UI
{
    public partial class DepartmentHead: Form
    {
        public DepartmentHead()
        {
            InitializeComponent();
        }

        private void Assignworkload_btn_Click(object sender, EventArgs e)
        {
            WorkLoad work = new WorkLoad();
            work.Show();
            work.Size = this.Size;
            work.Location = this.Location;
            this.Close();
        }

        private void Approvereq_btn_Click(object sender, EventArgs e)
        {
            Fulfulreqs req = new Fulfulreqs();
            req.Show();
            req.Size = this.Size;
            req.Location = this.Location;
            this.Close();
        }

        private void Allocation_btn_Click(object sender, EventArgs e)
        {
            SechdulingCourse2 sechduling = new SechdulingCourse2();
            sechduling.Show();
            sechduling.Size = this.Size;
            sechduling.Location = this.Location;
            this.Close();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoggedInUser.ClearSession();
            SignIn signIn = new SignIn();
            signIn.Show();
            signIn.Size = this.Size;
            signIn.Location = this.Location;
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Reports Reports = new Reports();
            Reports.Size = this.Size;
            Reports.Location = this.Location;
            Reports.Show();
            this.Close();
        }

        private void RoomAllocation_btn_Click(object sender, EventArgs e)
        {
            ResourseAllocation resourseAllocation = new ResourseAllocation();
            resourseAllocation.Show();
            resourseAllocation.Size = this.Size;
            resourseAllocation.Location = this.Location;
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AssignedCourses courses = new AssignedCourses();
            courses.Show();
            courses.Size = this.Size;
            courses.Location = this.Location;
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AssignedDuties Duties = new AssignedDuties();
            Duties.Show();
            Duties.Size = this.Size;
            Duties.Location = this.Location;
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Assignedprojects projects = new Assignedprojects();
            projects.Show();
            projects.Size = this.Size;
            projects.Location = this.Location;
            this.Close();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            AllocatedRoom room = new AllocatedRoom();
            room.Show();
            room.Size = this.Size;
            room.Location = this.Location;
            this.Close();
        }
    }
}
