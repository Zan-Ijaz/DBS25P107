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
    public partial class Fulfulreqs: Form
    {
        public Fulfulreqs()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            DepartmentHead depthead = new DepartmentHead();
            depthead.Show();
            depthead.Size = this.Size;
            depthead.Location = this.Location;
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Select reqid approved and remove things from consumeables
        }
    }
}
