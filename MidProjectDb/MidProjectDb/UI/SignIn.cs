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
            string signinusername = signinusername_txtbox.Text;
            string signinpassword = signinpassword_txtbox.Text;
            if(Utility.Utility.stringvalidation(signinusername_txtbox.Text)&& Utility.Utility.stringvalidation(signinpassword_txtbox.Text))
            {
                string query = $"Select* From users where username='{signinusername}' And password_hash=SHA2('{signinpassword}',256)";
            try
            {
                DataTable dt = DatabaseHelper.Instance.GetData(query);
                foreach(DataRow reader in dt.Rows)
                {
                        if (Convert.ToInt32(reader["role_id"]) == 1)
                        {
                            AdministrativeStaff admin = new AdministrativeStaff();
                            admin.Show();
                            admin.Size = this.Size;
                            admin.Location = this.Location;
                            this.Close();

                        }
                        else if (Convert.ToInt32(reader["role_id"]) == 2)
                        {
                            Faculty_Members faculty = new Faculty_Members();
                            faculty.Show();
                            faculty.Size = this.Size;
                            faculty.Location = this.Location;
                            this.Close();

                        }
                        else if (Convert.ToInt32(reader["role_id"]) == 3)
                        {
                            DepartmentHead depthead = new DepartmentHead();
                            depthead.Show();
                            depthead.Size = this.Size;
                            depthead.Location = this.Location;
                            this.Close();

                        }
                        else
                        {
                        throw new Exception("Wrong Credentials.");
                        }
                    
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            }
            else
            {
                MessageBox.Show("Invaid String added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                signinusername_txtbox.Text = "";
                signinpassword_txtbox.Text = "";
            }



        }
    }
}
