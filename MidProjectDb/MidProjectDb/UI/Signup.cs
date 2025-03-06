using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using MidProjectDb.DL;
using MidProjectDb.BL;
namespace MidProjectDb.UI
{
    public partial class Signup: Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        private void Next_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (User.nameduplication(signupusername_txtbox.Text)&& Utility.Utility.stringvalidation(signupusername_txtbox.Text))
                {
                    string name = signupusername_txtbox.Text;
                }
                else
                {
                    signupusername_txtbox.Text = "";
                    if (!User.nameduplication(signupusername_txtbox.Text))
                    {
                        MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!Utility.Utility.stringvalidation(signupusername_txtbox.Text))
                    {
                        MessageBox.Show("Invalid String", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                if (signuppass_txtbox.Text.Length >= 8&& Utility.Utility.stringvalidation(signuppass_txtbox.Text))
                {
                    string password =/*SHA256*/(signuppass_txtbox.Text);
                }
                else
                {
                    signupusername_txtbox.Text = "";
                    MessageBox.Show("Password shold be atleast 8 characters and valid string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if(User.emailvalidation(email_txtbox.Text)&&User.emailduplication(email_txtbox.Text))
                {
                    string email = email_txtbox.Text;
                }
                else
                {
                    email_txtbox.Text = "";
                    if (!User.emailvalidation(email_txtbox.Text))
                    {
                        MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!User.emailduplication(email_txtbox.Text))
                    {
                        MessageBox.Show("Email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (contact_txtbox.Text.Length == 11&&Faculty.intValidatioin(contact_txtbox.Text))
                {
                    string contactnumber = contact_txtbox.Text;
                    
                }
                else
                {
                    contact_txtbox.Text = "";
                    if (contact_txtbox.Text.Length != 11)
                    {
                        MessageBox.Show("Contact number must be 11 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!Faculty.intValidatioin(contact_txtbox.Text))
                    {
                        MessageBox.Show("Contact number must Contain only digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                string research = reserch_interest_txtbox.Text;
                int availablehours = Convert.ToInt32(teaching_hours_txtbox.Text);
                string designation = comboBox1.SelectedItem?.ToString() ?? "";
                Lookup look = Lookup.findlookup(designation);
                User user = new User(name, email, password, look.lookupid, look);
                UserDL.insertUser(user);
                int userid = User.findid(name);
                Faculty faculty = new Faculty(name, email, contactnumber, research, availablehours, userid, look.lookupid);
                FacultyDL.insertfaculty(faculty);

                AdministrativeStaff admin = new AdministrativeStaff();
                admin.Show();
                admin.Size = this.Size;
                admin.Location = this.Location;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            AdministrativeStaff admin = new AdministrativeStaff();
            admin.Show();
            admin.Size = this.Size;
            admin.Location = this.Location;
            this.Close();
        }
    }
}
