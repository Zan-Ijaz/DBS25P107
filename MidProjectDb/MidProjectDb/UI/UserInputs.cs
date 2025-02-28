using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace MidProjectDb.UI
{
    public partial class UserInputs: Form
    {
        public UserInputs()
        {
            InitializeComponent();
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            if (Userinfo_lbl.Text== "Update Faculty")
            {
                Signup signupform = new Signup();
                signupform.Addfaculty_lbl.Text = "Update Faculty";
                signupform.Show();
                signupform.Size = this.Size;
                signupform.Location = this.Location;
                this.Close();

            }
            else
            {
                this.Close();

            }

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            FacultyManagement management = new FacultyManagement();
            management.Show();
            management.Size = this.Size;
            management.Location = this.Location;
            this.Close();
        }
    }
}
