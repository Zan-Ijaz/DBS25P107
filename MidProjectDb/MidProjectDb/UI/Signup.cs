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
            try
            {
                if (User.nameduplication(signupusername_txtbox.Text) && Utility.Utility.stringvalidation(signupusername_txtbox.Text))
                {
                    name = signupusername_txtbox.Text;
                }
                else
                {
                    if (!User.nameduplication(signupusername_txtbox.Text))
                    {
                        MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!Utility.Utility.stringvalidation(signupusername_txtbox.Text))
                    {
                        MessageBox.Show("Invalid String added as username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    signupusername_txtbox.Text = "";
                }
                if (signuppass_txtbox.Text.Length >= 8 &&Utility.Utility.intValidatioin(signuppass_txtbox.Text))
                {
                    password =(signuppass_txtbox.Text);
                }
                else
                {
                    signuppass_txtbox.Text = "";
                    MessageBox.Show("Password shold be atleast 8 characters and a valid string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (User.emailvalidation(email_txtbox.Text) && User.emailduplication(email_txtbox.Text))
                {
                    email = email_txtbox.Text;
                }
                else
                {
                    if (!User.emailvalidation(email_txtbox.Text))
                    {
                        MessageBox.Show("Invalid Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!User.emailduplication(email_txtbox.Text))
                    {
                        MessageBox.Show("Email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    email_txtbox.Text = "";
                }
                if (contact_txtbox.Text.Length == 11 && Utility.Utility.intValidatioin(contact_txtbox.Text) && Faculty.numberdup(contact_txtbox.Text))
                {
                    contactnumber = contact_txtbox.Text;

                }
                else
                {
                    if (contact_txtbox.Text.Length != 11)
                    {
                        MessageBox.Show("Contact number must be 11 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!Utility.Utility.intValidatioin(contact_txtbox.Text))
                    {
                        MessageBox.Show("Contact number must Contain only digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (!Faculty.numberdup(contact_txtbox.Text))
                    {
                        MessageBox.Show("Contact number already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    contact_txtbox.Text = "";
                }
                if (Utility.Utility.stringvalidation(reserch_interest_txtbox.Text))
                {
                    research = reserch_interest_txtbox.Text;
                }
                else
                {
                    reserch_interest_txtbox.Text = "";
                    MessageBox.Show("Invalid String as research interest", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
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
                if (name != "" && password != "" && email != "" && contactnumber != "" && research != "" && designation != "" && availablehours > -01)
                {
                    Lookup look = Lookup.findlookup(designation);
                    User user = new User(name, email, password, look.lookupid, look);
                    UserDL.insertUser(user);
                    int userid = User.findid(name);
                    Faculty faculty = new Faculty(name, email, contactnumber, research, availablehours, userid, look.lookupid);
                    FacultyDL.insertfaculty(faculty);
                    MessageBox.Show("User added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    signupusername_txtbox.Text = "";
                    signuppass_txtbox.Text = "";
                    email_txtbox.Text = "";
                    contact_txtbox.Text = "";
                    reserch_interest_txtbox.Text = "";
                    teaching_hours_txtbox.Text = "";
                    comboBox1.Text = "";

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
                string query = $"SELECT f.name as Name,f.email as Email ,f.contact as Contact ,d.value as Designation,f.research_area as ResearchArea,f.total_teaching_hours as TotalTeachingHours,r.value as Role,f.user_id as UserID from faculty f inner join lookup d on f.designation_id=d.lookup_id inner join users as u on f.user_id=u.user_id inner join lookup r on u.role_id=r.lookup_id order by role";
                DataTable dt = new DataTable();
                var reader=DatabaseHelper.Instance.getData(query);
                if (reader != null)
                {
                    dt.Load(reader); 
                    reader.Close(); 
                }
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
                        int totalHours = -01;
                        int userid = Convert.ToInt32(row["UserID"]);
                        if (Utility.Utility.stringvalidation(row["Name"].ToString())&&User.nameduplication(row["Name"].ToString(),userid))
                        {
                            name = row["Name"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Invalid string added as username or username already exists,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        if (Utility.Utility.stringvalidation(row["Email"].ToString()) && User.emailvalidation(row["Email"].ToString()) && User.nameduplication(row["Email"].ToString(), userid))
                        {
                            email = row["Email"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email added or email already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        if(Utility.Utility.intValidatioin(row["Contact"].ToString())&&Faculty.numberdup(row["Contact"].ToString(),userid)){
                            contact = row["Contact"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Invalid phone number added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        string designation = row["Designation"].ToString();
                        Lookup designationlookup = Lookup.findlookup(designation);
                        if(Utility.Utility.stringvalidation(row["ResearchArea"].ToString()))
                        {
                            researchArea = row["ResearchArea"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Invalid string added as research", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        if(Utility.Utility.intValidatioin(row["TotalTeachingHours"].ToString()))
                        {
                            totalHours = Convert.ToInt32(row["TotalTeachingHours"]);
                        }
                        else
                        {
                            MessageBox.Show("Invalid total hours added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        string role = row["Role"].ToString();
                        int hodcount = UserDL.hodCount(userid);
                        if (role == "Department Head" && hodcount > 0)
                        {
                            MessageBox.Show("A HoD is already available. User will remain faculty member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            role = "Faculty";
                        }
                        Lookup rolellokup = Lookup.findlookup(role);
                        if(name!=""&&email!=""&&contact!=""&&researchArea!=""&&totalHours>=0){
                        string userquery = $"Update users set username='{name}', email='{email}', role_id='{rolellokup.lookupid}' where user_id='{userid}' ";
                        DatabaseHelper.Instance.Update(userquery);
                        string facultyquery = $"Update faculty set name='{name}', email='{email}', contact='{contact}', designation_id='{designationlookup.lookupid}', research_area='{researchArea}', total_teaching_hours='{totalHours}' where user_id='{userid}'";
                            DatabaseHelper.Instance.Update(facultyquery);
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
                        string deleteFacultyQuery = $"DELETE FROM faculty WHERE user_id = {userId}";
                        DatabaseHelper.Instance.Update(deleteFacultyQuery);
                        string deleteUserQuery = $"DELETE FROM users WHERE user_id = {userId}";
                        DatabaseHelper.Instance.Update(deleteUserQuery);
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