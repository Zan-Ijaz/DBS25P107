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
    public partial class SechdulingCourse2: Form
    {
        public SechdulingCourse2()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            Sechduling sechduling = new Sechduling();
            sechduling.Show();
            sechduling.Size = this.Size;
            sechduling.Location = this.Location;
            this.Close();
        }
    }
}
