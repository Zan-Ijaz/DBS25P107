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
    public partial class ResourseAllocation: Form
    {
        public ResourseAllocation()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            DepartmentHead head = new DepartmentHead();
            head.Show();
            head.Size = this.Size;
            head.Location = this.Location;
            this.Close();
        }
    }
}
