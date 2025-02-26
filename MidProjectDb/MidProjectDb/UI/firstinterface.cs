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

        private void SignIn_btn_Click(object sender, EventArgs e)
        {
            SignIn signinform = new SignIn();
            signinform.Show();
            signinform.Size = this.Size;
            signinform.Location = this.Location;
            this.Close();
        }
    }
}
