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
            CourseAllocationfirst course = new CourseAllocationfirst();
            course.Show();
            course.Size = this.Size;
            course.Location = this.Location;
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
    }
}
