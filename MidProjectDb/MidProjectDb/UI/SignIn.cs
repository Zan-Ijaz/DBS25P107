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
    public partial class SignIn: Form
    {
        public SignIn()
        {
            InitializeComponent();
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
            string signinusername = signinusername_txtbox.Text;
            string signinpassword = signinpassword_txtbox.Text;
            try
            {
                DataRow dr=User.signin(signinusername, signinpassword);
                LoggedInUser.SetLoggedInUser(dr);
               if(dr!=null)
                {
                        if (Convert.ToInt32(dr["role_id"]) == 1)
                        {
                            AdministrativeStaff admin = new AdministrativeStaff();
                            admin.Show();
                            admin.Size = this.Size;
                            admin.Location = this.Location;
                            this.Close();
                        }
                        else if (Convert.ToInt32(dr["role_id"]) == 2)
                        {
                            Faculty_Members faculty = new Faculty_Members();
                            faculty.Show();
                            faculty.Size = this.Size;
                            faculty.Location = this.Location;
                            this.Close();
                        }
                        else if (Convert.ToInt32(dr["role_id"]) == 3)
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
                    throw new Exception("Wrong Credentials.");
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                   
        }
    }
}
