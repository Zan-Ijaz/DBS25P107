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
using System.Linq.Expressions;
using System.Web.Security;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
            string name = "", password = "", email = "", contactnumber = "", research = "", designation="";
            int availablehours = -1;
            string errorMessage = "", errorMessage2 = "";
            try
            {
                name = signupusername_txtbox.Text;
                if (signuppass_txtbox.Text.Length >= 8 &&Utility.Utility.intValidatioin(signuppass_txtbox.Text))
                {
                    password =(signuppass_txtbox.Text);
                }
                else
                {
                    signuppass_txtbox.Text = "";
                    MessageBox.Show("Password shold be atleast 8 characters and a valid string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    email = email_txtbox.Text;
                    contactnumber = contact_txtbox.Text;
                    research = reserch_interest_txtbox.Text;
                if (Utility.Utility.intValidatioin(teaching_hours_txtbox.Text))
                {
                    availablehours = Convert.ToInt32(teaching_hours_txtbox.Text);
                }
                else
                {
                    teaching_hours_txtbox.Text = "";
                    MessageBox.Show("Invalid hours selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
                if (comboBox1.SelectedIndex != -1)
                {
                    designation = comboBox1.SelectedItem?.ToString() ?? "";
                }
                else
                {
                    MessageBox.Show("No designation selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Lookup look = Lookup.findlookup(designation);
                if(comboBox1.SelectedIndex != -1 &&availablehours>0&&password!="")//Doing this validation here bcz object takes int so its validation must be done before adding to object
                {
                    User user = new User(name, email, password, look.lookupid, look);
                    int userid = User.findid(name);
                    Faculty faculty = new Faculty(name, email, contactnumber, research, availablehours, userid, look.lookupid);
                    bool isUserValid = User.ValidateUser(user, out errorMessage);
                    bool isFacultyValid = Faculty.validationsCheck(faculty, out errorMessage2);
                if (isUserValid && isFacultyValid)
                {
                    User.insert(user);
                    Faculty.insert(faculty);
                    MessageBox.Show("User added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    signupusername_txtbox.Text = "";
                    signuppass_txtbox.Text = "";
                    email_txtbox.Text = "";
                    contact_txtbox.Text = "";
                    reserch_interest_txtbox.Text = "";
                    teaching_hours_txtbox.Text = "";
                    comboBox1.Text = "";
                }
                else
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(errorMessage2, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                }
                LoadDataGrid();
               
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
        private void Signup_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            
        }
        private void LoadDataGrid()
        {
            try
            {
                DataTable dt = User.loadSignupGRID();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["UserID"].ReadOnly = true;
                AddDesignationDropdown();
                AddRoleDropdown();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Update_btn_Click(object sender, EventArgs e)
        {
            try{
            DataTable dt = new DataTable();
            if (dataGridView1.DataSource != null)
            {
                dt = (DataTable)dataGridView1.DataSource;
                    foreach (DataRow row in dt.Rows)
                    {
                        string name = "", email="", contact="", researchArea="";
                        int totalHours = 0;
                        int userid = Convert.ToInt32(row["UserID"]);
                        name = row["Name"].ToString();
                        email = row["Email"].ToString();
                        string designation = row["Designation"].ToString();
                        Lookup designationlookup = Lookup.findlookup(designation);
                        contact = row["Contact"].ToString();
                        researchArea = row["ResearchArea"].ToString();
                        string role = row["Role"].ToString();
                        if(Utility.Utility.intValidatioin(row["TotalTeachingHours"].ToString())&& Convert.ToInt32(row["TotalTeachingHours"])>0)
                        {
                            totalHours = Convert.ToInt32(row["TotalTeachingHours"]);
                        }
                        else
                        {
                            MessageBox.Show("Invaild teaching hours added", "User Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //Role validation
                        int hodcount = UserDL.hodCount(userid);
                        if (role == "Department Head" && hodcount > 0)
                        {
                            MessageBox.Show("A HoD is already available. User will remain faculty member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            role = "Faculty";
                        }
                        Lookup rolellokup = Lookup.findlookup(role);                
                        string errorMessage;
                        string errorMessage2;
                        if(totalHours>0)//Doing this validation here bcz object takes int so its validation must be done before adding to object
                        {
                        User user = new User(userid, name, email, rolellokup.lookupid, rolellokup);
                        Faculty faculty = new Faculty(name, email, contact, researchArea, totalHours, userid, designationlookup.lookupid);
                        bool isUserValid = User.ValidateUser(user, out errorMessage);
                        bool isFacultyValid = Faculty.validationsCheck(faculty, out errorMessage2);
                            if (isUserValid && isFacultyValid)
                            {
                                User.update(user);
                                Faculty.update(faculty);
                            }
                            else
                            {
                                if (!isUserValid)
                                {
                                    MessageBox.Show(errorMessage, "User Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                if (!isFacultyValid)
                                {
                                    MessageBox.Show(errorMessage2, "User Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            LoadDataGrid();
        }
        private void AddDesignationDropdown()
        {
            if (dataGridView1.Columns["Designation"] != null)
            {
                dataGridView1.Columns["Designation"].Visible = false;
            }
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.DataPropertyName = "Designation"; 
            comboBoxColumn.HeaderText = "Designation";
            comboBoxColumn.Items.Add("Professor");
            comboBoxColumn.Items.Add("Lecturer");
            comboBoxColumn.Items.Add("Assistant Professor");
            comboBoxColumn.Items.Add("Research Associate");
            dataGridView1.Columns.Add(comboBoxColumn);
        }
        private void AddRoleDropdown()
        {
            if (dataGridView1.Columns["Role"] != null)
            {
                dataGridView1.Columns["Role"].Visible = false;
            }
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            comboBoxColumn.DataPropertyName = "Role";
            comboBoxColumn.HeaderText = "Role";
            comboBoxColumn.Items.Add("Faculty");
            comboBoxColumn.Items.Add("Department Head");
            dataGridView1.Columns.Add(comboBoxColumn);
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow();
        }
        private void DeleteSelectedRow()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        Faculty.delete(userId);
                        User.delete(userId);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDataGrid();

        }

    }

}