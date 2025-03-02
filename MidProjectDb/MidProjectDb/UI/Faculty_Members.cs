using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidProjectDb.UI
{
    public partial class Faculty_Members: Form
    {
        public Faculty_Members()
        {
            InitializeComponent();
        }

        private void Assigned_btn_Click(object sender, EventArgs e)
        {
            AssignedCourses courses = new AssignedCourses();
            courses.Show();
            courses.Size = this.Size;
            courses.Location = this.Location;
            this.Close();
        }

        private void Resreq_btn_Click(object sender, EventArgs e)
        {
            FacultyRequest request = new FacultyRequest();
            request.Show();
            request.Size = this.Size;
            request.Location = this.Location;
            this.Close();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            signIn.Size = this.Size;
            signIn.Location = this.Location;
            this.Close();
        }

        private void Trackreq_btn_Click(object sender, EventArgs e)
        {
            ViewReqs request = new ViewReqs();
            request.Show();
            request.Size = this.Size;
            request.Location = this.Location;
            this.Close();
        }
    }
}
