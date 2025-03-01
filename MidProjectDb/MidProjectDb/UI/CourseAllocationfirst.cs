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
    public partial class CourseAllocationfirst: Form
    {
        public CourseAllocationfirst()
        {
            InitializeComponent();
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            CourseAllocation course = new CourseAllocation();
            course.Show();
            course.Size = this.Size;
            course.Location = this.Location;
            this.Close();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            WorkLoad work = new WorkLoad();
            work.Show();
            work.Size = this.Size;
            work.Location = this.Location;
            this.Close();

        }
    }
}
