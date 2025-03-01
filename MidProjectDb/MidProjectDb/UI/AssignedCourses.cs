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
    public partial class AssignedCourses: Form
    {
        public AssignedCourses()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            Faculty_Members fac = new Faculty_Members();
            fac.Show();
            fac.Size = this.Size;
            fac.Location = this.Location;
            this.Close();
        }
    }
}
