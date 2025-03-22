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
    public partial class ResourseAllocation: Form
    {
        public ResourseAllocation()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            DepartmentHead head = new DepartmentHead();
            head.Show();
            head.Size = this.Size;
            head.Location = this.Location;
            this.Close();
        }

        private void ResourseAllocation_Load(object sender, EventArgs e)
        {
            loadDatagrid();
        }
        private void loadCombobox()
        {
            List<Faculty> faculty = Faculty.getList();
            if(faculty!=null)
            {
                faculty_comboBox.DataSource = faculty;
                faculty_comboBox.DisplayMember = "Name";
                faculty_comboBox.ValueMember = "FacultyId";
                faculty_comboBox.SelectedIndex = -1;
            }
            List<Room> rooms = Room.getData();
            if (rooms != null)
            {
                Room_comboBox.DataSource = rooms;
                Room_comboBox.DisplayMember = "roomname";
                Room_comboBox.ValueMember = "roomid";
                Room_comboBox.SelectedIndex = -1;

            }
            List<Semester> semesters = Semester.getList();
            if (semesters != null)
            {
                var formattedSemesters = semesters.Select(s => new
                {
                    DisplayText = $"{s.Term} {s.Year}", 
                    SemesterId = s.SemesterId
                }).ToList();
                semester_comboBox.DataSource = formattedSemesters;
                semester_comboBox.DisplayMember = "DisplayText"; 
                semester_comboBox.ValueMember = "SemesterId"; 
                semester_comboBox.SelectedIndex = -1;
            }
        }
        private void loadDatagrid()
        {
            try{
                List<Facultyroom> rooms = Facultyroom.getData();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = rooms;
                dataGridView1.Columns["allocationid"].ReadOnly = true;
                dataGridView1.Columns["facultyid"].Visible = false;
                dataGridView1.Columns["roomid"].Visible = false;
                dataGridView1.Columns["semesterid"].Visible = false;
                loadCombobox();
                loadDropDowns();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadDropDowns()
        {
            List<Faculty> faculty = Faculty.getList();
            if (dataGridView1.Columns["faculty"] != null)
            {
                dataGridView1.Columns.Remove("faculty");
            }
            DataGridViewComboBoxColumn facultycombobox = new DataGridViewComboBoxColumn();
            facultycombobox.Name = "faculty";
            facultycombobox.HeaderText = "Faculty";
            facultycombobox.DataSource = faculty;
            facultycombobox.DisplayMember = "Name";
            facultycombobox.ValueMember = "FacultyId";
            facultycombobox.DataPropertyName = "FacultyId";
            dataGridView1.Columns.Add(facultycombobox);

            List<Room> rooms = Room.getData();
            if (dataGridView1.Columns["room"] != null)
            {
                dataGridView1.Columns.Remove("room");
            }
            DataGridViewComboBoxColumn roomcombobox = new DataGridViewComboBoxColumn();
            roomcombobox.Name = "room";
            roomcombobox.HeaderText = "Rooms";
            roomcombobox.DataSource = rooms;
            roomcombobox.DisplayMember = "roomname";
            roomcombobox.ValueMember = "roomid";
            roomcombobox.DataPropertyName = "roomid";
            dataGridView1.Columns.Add(roomcombobox);
            if (dataGridView1.Columns["semester"] != null)
            {
                dataGridView1.Columns.Remove("semester");
            }
            List<Semester> semesters = Semester.getList();
            foreach (var sem in semesters)
            {
                sem.Term = $"{sem.Term} {sem.Year}";
            }
            DataGridViewComboBoxColumn semcombobox = new DataGridViewComboBoxColumn();
            semcombobox.Name = "Semester";
            semcombobox.HeaderText = "Semester";
            semcombobox.DataSource = semesters;
            semcombobox.DisplayMember = "term";
            semcombobox.ValueMember = "semesterid";
            semcombobox.DataPropertyName = "semesterid";
            dataGridView1.Columns.Add(semcombobox);
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
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete Selected records?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            int id = Convert.ToInt32(row.Cells["allocationid"].Value);
                            Facultyroom.delete(id);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            loadDatagrid();
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (faculty_comboBox.SelectedIndex != -1 && semester_comboBox.SelectedIndex != -1 && Room_comboBox.SelectedIndex != -1 && Utility.Utility.intValidatioin(reservedhres_txtbox.Text.ToString()))
                {
                    int facultyid = Convert.ToInt32(faculty_comboBox.SelectedValue);
                    int roomid = Convert.ToInt32(Room_comboBox.SelectedValue);
                    int semid = Convert.ToInt32(semester_comboBox.SelectedValue);
                    int hours = Convert.ToInt32(reservedhres_txtbox.Text);
                    Faculty f = Faculty.findFaculty(facultyid);
                    Room r = Room.findroom(roomid);
                    Semester s = Semester.findSem(semid);
                    Facultyroom fr = new Facultyroom(hours, facultyid, roomid, semid, f, r, s);
                    if (Facultyroom.add(fr))
                    {
                        MessageBox.Show("Room assigned successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reservedhres_txtbox.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Faculty is already assigned this room for selected semester", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter all required data and enter valid hours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loadDatagrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int allocationids = Convert.ToInt32(row.Cells["allocationid"].Value);
                    int roomid = Convert.ToInt32(row.Cells["room"].Value);
                    int facultyid = Convert.ToInt32(row.Cells["faculty"].Value);
                    int semid = Convert.ToInt32(row.Cells["semester"].Value);
                    int hrs = 0;
                    Faculty f = Faculty.findFaculty(facultyid);
                    Room r = Room.findroom(roomid);
                    Semester s = Semester.findSem(semid);
                    if (Utility.Utility.intValidatioin(row.Cells["reservedHours"].Value.ToString()))
                    {
                        hrs = Convert.ToInt32(row.Cells["reservedHours"].Value);
                    }
                    Facultyroom fr = new Facultyroom(allocationids, hrs, facultyid, roomid, semid, f, r, s);
                    if (!Facultyroom.update(fr))
                    {
                        MessageBox.Show("Faculty is already assigned this room or invalid hours added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            loadDatagrid();
        }
    }
}
