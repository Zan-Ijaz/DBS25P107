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
    public partial class Addfac: Form
    {
        public Addfac()
        {
            InitializeComponent();
        }
        private void Back_btn_Click(object sender, EventArgs e)
        {
            AdministrativeStaff admin = new AdministrativeStaff();
            admin.Show();
            admin.Size = this.Size;
            admin.Location = this.Location;
            this.Close();
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            string name = "", password = "", email = "", contactnumber = "", research = "", designation = "";
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
                if (signuppass_txtbox.Text.Length >= 8 && Utility.Utility.intValidatioin(signuppass_txtbox.Text))
                {
                    password = (signuppass_txtbox.Text);
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
                if (name != "" && password != "" && email != "" && contactnumber != "" && research != "" && comboBox1.SelectedIndex != -1 && availablehours > -01)
                {
                    Lookup designationlook = Lookup.findlookup(designation);
                    Lookup rolelookup = Lookup.findlookup("Faculty");
                    User user = new User(name, email, password, rolelookup.lookupid, rolelookup);
                    User.insert(user);
                    int userid = User.findid(name);
                    Faculty faculty = new Faculty(name, email, contactnumber, research, availablehours, userid, designationlook.lookupid);
                    Faculty.insert(faculty);
                    MessageBox.Show("User added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    signupusername_txtbox.Text = "";
                    signuppass_txtbox.Text = "";
                    email_txtbox.Text = "";
                    contact_txtbox.Text = "";
                    reserch_interest_txtbox.Text = "";
                    teaching_hours_txtbox.Text = "";
                    comboBox1.SelectedIndex = -1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDataGrid();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (dataGridView1.DataSource != null)
                {
                    dt = (DataTable)dataGridView1.DataSource;
                    foreach (DataRow row in dt.Rows)
                    {
                        string name = "", email = "", contact = "", researchArea = "";
                        int totalHours = 0;
                        int userid = Convert.ToInt32(row["UserID"]);
                        name = row["Name"].ToString();
                        email = row["Email"].ToString();
                        string designation = row["Designation"].ToString();
                        Lookup designationlookup = Lookup.findlookup(designation);
                        contact = row["Contact"].ToString();
                        researchArea = row["ResearchArea"].ToString();
                        string role = row["Role"].ToString();
                        if (Utility.Utility.intValidatioin(row["TotalTeachingHours"].ToString()) && Convert.ToInt32(row["TotalTeachingHours"]) > 0)
                        {
                            totalHours = Convert.ToInt32(row["TotalTeachingHours"]);
                        }
                        else
                        {
                            MessageBox.Show("Invaild teaching hours added", "User Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //Role validation
                        int hodcount = User.hod(userid);
                        if (role == "Department Head" && hodcount > 0)
                        {
                            MessageBox.Show("A HoD is already available. User will remain faculty member", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            role = "Faculty";
                        }
                        Lookup rolellokup = Lookup.findlookup(role);
                        string errorMessage;
                        string errorMessage2;
                        if (totalHours > 0)//Doing this validation here bcz object takes int so its validation must be done before adding to object
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            LoadDataGrid();
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
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete selected records?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                        {
                            int Id = Convert.ToInt32(dr.Cells["UserID"].Value);

                            Faculty.delete(Id);
                            User.delete(Id);
                        }
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
            comboBoxColumn.Items.Add("Associate Professor");
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

        private void Addfac_Load(object sender, EventArgs e)
        {
            LoadDataGrid();

        }
    }
}
