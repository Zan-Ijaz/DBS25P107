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
    public partial class AdministrativeStaff: Form
    {
        public AdministrativeStaff()
        {
            InitializeComponent();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            FacultyManagement management = new FacultyManagement();
            management.Show();
            management.Size = this.Size;
            management.Location = this.Location;
            this.Close();
        }
    }
}
