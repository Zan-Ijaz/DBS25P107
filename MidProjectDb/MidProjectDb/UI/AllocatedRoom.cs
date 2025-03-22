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
    public partial class AllocatedRoom: Form
    {
        public AllocatedRoom()
        {
            InitializeComponent();
        }

        private void Back_lbl_Click(object sender, EventArgs e)
        {
            int role = Convert.ToInt32(LoggedInUser.LoggedUser["role_id"]);
            if (role == 2)
            {
                Faculty_Members fac = new Faculty_Members();
                fac.Show();
                fac.Size = this.Size;
                fac.Location = this.Location;
                this.Close();
            }
            if (role == 3)
            {
                DepartmentHead head = new DepartmentHead();
                head.Size = this.Size;
                head.Location = this.Location;
                head.Show();
                this.Close();
            }
        }

        private void AllocatedRoom_Load(object sender, EventArgs e)
        {
            loadDataGrid();
        }
        private void loadDataGrid()
        {
            DataRow dr = LoggedInUser.LoggedUser;
            string email = dr["email"].ToString();
            Faculty f = Faculty.findFaculty(email);
            var formattedrooms = Facultyroom.getData()
                .Where(c => c.facultyid == f.FacultyId)
                .Select(c => new
                {
                    AllocationId = c.allocationid,
                    ReservedHours = c.reservedHours,
                    Semester = $"{c.semester.Term} {c.semester.Year}",
                    Room = c.room.roomname
                }).ToList();
            dataGridView1.DataSource = formattedrooms;
        }
    }
}
