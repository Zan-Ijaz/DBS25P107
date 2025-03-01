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
    public partial class CourseAllocation: Form
    {
        public CourseAllocation()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            CourseAllocationfirst course = new CourseAllocationfirst();
            course.Show();
            course.Size = this.Size;
            course.Location = this.Location;
            this.Close();
        }
    }
}
