using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidProjectDb.UI;

namespace MidProjectDb
{
    public partial class firstinterface: Form
    {
        public firstinterface()
        {
            InitializeComponent();
        }

      
        private void Signup_btn_Click_1(object sender, EventArgs e)
        {
            Signup signupform = new Signup();
            signupform.Show();
            signupform.Size = this.Size;
            signupform.Location = this.Location;
            this.Close();
        }

        private void Signin_btn_Click_1(object sender, EventArgs e)
        {
            SignIn signinform = new SignIn();
            signinform.Show();
            signinform.Size = this.Size;
            signinform.Location = this.Location;
            this.Close();
        }
    }
}
