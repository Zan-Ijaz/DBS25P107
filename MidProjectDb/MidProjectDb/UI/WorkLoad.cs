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
    public partial class WorkLoad: Form
    {
        public WorkLoad()
        {
            InitializeComponent();
        }

        private void CourseAlloca_btn_Click(object sender, EventArgs e)
        {
            CourseAllocationfirst course = new CourseAllocationfirst();
            course.Show();
            course.Size = this.Size;
            course.Location = this.Location;
            this.Close();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            DepartmentHead depthead = new DepartmentHead();
            depthead.Show();
            depthead.Size = this.Size;
            depthead.Location = this.Location;
            this.Close();
        }

        private void ResearchSuper_btn_Click(object sender, EventArgs e)
        {
            ResearchSuper research = new ResearchSuper();
            research.Show();
            research.Size = this.Size;
            research.Location = this.Location;
            this.Close();
        }
    }
}
