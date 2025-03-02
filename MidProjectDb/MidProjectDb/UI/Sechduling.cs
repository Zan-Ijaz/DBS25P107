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
    public partial class Sechduling: Form
    {
        public Sechduling()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            AdministrativeStaff admin = new AdministrativeStaff();
            admin.Show();
            admin.Size = this.Size;
            admin.Location = this.Location;
            this.Close();
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            SechdulingCourse2 sechduling = new SechdulingCourse2();
            sechduling.Show();
            sechduling.Size = this.Size;
            sechduling.Location = this.Location;
            this.Close();
        }
    }
}
