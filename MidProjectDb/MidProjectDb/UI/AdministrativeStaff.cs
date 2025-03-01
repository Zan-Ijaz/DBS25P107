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
    public partial class AdministrativeStaff: Form
    {
        public AdministrativeStaff()
        {
            InitializeComponent();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            FacultyManagement management = new FacultyManagement();
            management.Show();
            management.Size = this.Size;
            management.Location = this.Location;
            this.Close();
        }

        private void Courseallocation_btn_Click(object sender, EventArgs e)
        {
            Sechduling sechduling = new Sechduling();
            sechduling.Show();
            sechduling.Size = this.Size;
            sechduling.Location = this.Location;
            this.Close();

        }

        private void ManageCourse_btn_Click(object sender, EventArgs e)
        {
            ManageCourse manageCourse = new ManageCourse();
            manageCourse.Show();
            manageCourse.Size = this.Size;
            manageCourse.Location = this.Location;
            this.Close();
        }

        private void Processfaculty_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void room_btn_Click(object sender, EventArgs e)
        {
            Rooms rooms=new Rooms();
            rooms.Show();
            rooms.Size = this.Size;
            rooms.Location = this.Location;
            this.Close();

        }

        private void Project_btn_Click(object sender, EventArgs e)
        {
            ManageProducts projects = new ManageProducts();
            projects.Show();
            projects.Size = this.Size;
            projects.Location = this.Location;
            this.Close();
        }

        private void Semester_btn_Click(object sender, EventArgs e)
        {
            UpdateSem sem = new UpdateSem();
            sem.Show();
            sem.Size = this.Size;
            sem.Location = this.Location;
            this.Close();
        }

        private void Consumeable_btn_Click(object sender, EventArgs e)
        {
            Consumeables Consum = new Consumeables();
            Consum.Show();
            Consum.Size = this.Size;
            Consum.Location = this.Location;
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
    }
}
