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
    public partial class SetPassword: Form
    {
        public SetPassword()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string password = setpassword_txtbox.Text;
            DataRow currentuser = LoggedInUser.LoggedUser;
            if (User.changepassword(currentuser, password))
            {
                MessageBox.Show("Password change sucessfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Now logning in 
                if (Convert.ToInt32(currentuser["role_id"]) == 1)
                {
                    AdministrativeStaff admin = new AdministrativeStaff();
                    admin.Show();
                    admin.Size = this.Size;
                    admin.Location = this.Location;
                    this.Close();
                }
                else if (Convert.ToInt32(currentuser["role_id"]) == 2)
                {
                    Faculty_Members faculty = new Faculty_Members();
                    faculty.Show();
                    faculty.Size = this.Size;
                    faculty.Location = this.Location;
                    this.Close();
                }
                else if (Convert.ToInt32(currentuser["role_id"]) == 3)
                {
                    DepartmentHead depthead = new DepartmentHead();
                    depthead.Show();
                    depthead.Size = this.Size;
                    depthead.Location = this.Location;
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Password must be 8 characters and a valid string", "Erroe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    
    }
}
