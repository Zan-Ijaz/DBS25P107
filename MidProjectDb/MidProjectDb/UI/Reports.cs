using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidProjectDb.BL;

namespace MidProjectDb.UI
{
    public partial class Reports: Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            int role = Convert.ToInt32(LoggedInUser.LoggedUser["role_id"]);
            if (role == 1)
            {
                AdministrativeStaff admin = new AdministrativeStaff();
                admin.Size = this.Size;
                admin.Location = this.Location;
                admin.Show();
                this.Close();
            }
            else if (role == 3)
            {
                DepartmentHead head = new DepartmentHead();
                head.Size = this.Size;
                head.Location = this.Location;
                head.Show();
                this.Close();
            }
        }
    }
}
