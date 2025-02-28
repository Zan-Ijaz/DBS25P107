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
    public partial class Forgotpassword: Form
    {
        public Forgotpassword()
        {
            InitializeComponent();
        }
        private void Next_btn_Click_1(object sender, EventArgs e)
        {
            SetPassword passwordform = new SetPassword();
            passwordform.Show();
            passwordform.Size = this.Size;
            passwordform.Location = this.Location;
            this.Close();
        }

        private void Signin_btn_Click(object sender, EventArgs e)
        {
            SignIn signinform = new SignIn();
            signinform.Show();
            signinform.Size = this.Size;
            signinform.Location = this.Location;
            this.Close();
        }
    }
}
