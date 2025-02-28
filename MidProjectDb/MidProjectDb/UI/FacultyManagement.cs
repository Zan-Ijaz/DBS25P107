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
    public partial class FacultyManagement: Form
    {
        public FacultyManagement()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            AdministrativeStaff admin = new AdministrativeStaff();
            admin.Show();
            admin.Size = this.Size;
            admin.Location = this.Location;
            this.Close();
        }

        private void Addfaculty_btn_Click(object sender, EventArgs e)
        {
            Signup signupform = new Signup();
            signupform.Show();
            signupform.Size = this.Size;
            signupform.Location = this.Location;
            this.Close();
        }
    }
}
