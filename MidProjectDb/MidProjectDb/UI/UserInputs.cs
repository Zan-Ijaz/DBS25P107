using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using MidProjectDb.BL;

namespace MidProjectDb.UI
{
    public partial class UserInputs: Form
    {
        public UserInputs()
        {
            InitializeComponent();
            

        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            if (Userinfo_lbl.Text== "Update Faculty")
            {
                Signup signupform = new Signup();
                signupform.Addfaculty_lbl.Text = "Update Faculty";
                signupform.Show();
                signupform.Size = this.Size;
                signupform.Location = this.Location;
                this.Close();
                loadData();

            }
            else
            {
                this.Close();

            }

        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            FacultyManagement management = new FacultyManagement();
            management.Show();
            management.Size = this.Size;
            management.Location = this.Location;
            this.Close();
        }
        private void loadData()
        {
            //string query = $"Select * from users where role_id='{1}'";
            //try
            //{
            //    DatabaseHelper.Instance.getConnection();
            //    var reader = DatabaseHelper.Instance.getData(query);
            //    List<User> users = new List<User>();
            //    while (reader.Read())
            //    {
            //        int userid=Convert.ToInt32(reader["user_id"]);
            //        string username= reader["username"].ToString();
            //        string email= reader["email"].ToString();
            //        string password= reader["password_hash"].ToString();
            //        int roleId=Convert.ToInt32(reader["role_id"]);
            //        LookupBL role=LookupBL.findlookup(Convert.ToInt32(reader["role_id"]));
            //        User u = new User(userid,username,email,password,roleId,role);
            //        users.Add(u);
            //    }
            //    dataGridView1.DataSource = users;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }
    }
}
