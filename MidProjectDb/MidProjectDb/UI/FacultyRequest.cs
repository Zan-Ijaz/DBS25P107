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
    public partial class FacultyRequest: Form
    {
        public FacultyRequest()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            Faculty_Members faculty = new Faculty_Members();
            faculty.Show();
            faculty.Size = this.Size;
            faculty.Location = this.Location;
            this.Close();
        }
    }
}
