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
    public partial class SignIn: Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void Signup_btn_Click_1(object sender, EventArgs e)
        {
      
        }

        private void forgot_btn_Click(object sender, EventArgs e)
        {
            Forgotpassword forgotform = new Forgotpassword();
            forgotform.Show();
            forgotform.Size = this.Size;
            forgotform.Location = this.Location;
            this.Close();
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            AdministrativeStaff admin = new AdministrativeStaff();
            admin.Show();
            admin.Size = this.Size;
            admin.Location = this.Location;
            this.Close();
        }
    }
}
