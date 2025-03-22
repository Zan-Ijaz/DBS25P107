using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.BL;
using MidProjectDb.UI;

namespace MidProjectDb.DL
{
    public class FacultyadminDL
    {
        public DataTable GetDataTable()
        {
            string query = "Select * From faculty_admin_roles";
            DataTable dt= DatabaseHelper.Instance.GetData(query);
            return dt;
        }
        public List<Facultyadmin> GetData()
        {
            List<Facultyadmin> roles = new List<Facultyadmin>();
            string query = "Select * From faculty_admin_roles";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int adminRoleId = Convert.ToInt32(row["admin_role_id"]);
                    int facultyId = Convert.ToInt32(row["faculty_id"]);
                    string roleName = row["role_name"].ToString();
                    int semesterId = Convert.ToInt32(row["semester_id"]);
                    Faculty faculty =Faculty.findFaculty(facultyId) ;
                    Semester semester = Semester.findSem(semesterId);
                    Facultyadmin role = new Facultyadmin(adminRoleId, facultyId, roleName, semesterId, faculty, semester);
                    roles.Add(role);
                }
            }
            return roles;
        }
        public void InsertFacultyAdminRole(Facultyadmin role)
        {
            string query = $"Insert into faculty_admin_roles (faculty_id, role_name, semester_id) VALUES ({role.FacultyId}, '{role.RoleName}', {role.SemesterId})";
            DatabaseHelper.Instance.Update(query);
        }
        
        public void DeleteFacultyAdminRole(int id)
        {
            string query = $"DELETE From faculty_admin_roles WHERE admin_role_id = {id}";
            DatabaseHelper.Instance.Update(query);
        }
        public void UpdateFacultyAdminRole(Facultyadmin role)
        {
            string query = $"UPDATE faculty_admin_roles SET faculty_id = {role.FacultyId}, role_name = '{role.RoleName}', semester_id = {role.SemesterId} WHERE admin_role_id = {role.AdminRoleId}";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteBySem(int semesterId)
        {
            string query = $"DELETE From faculty_admin_roles WHERE semester_id = {semesterId}";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteByFaculty(int facultyId)
        {
            string query = $"DELETE From faculty_admin_roles WHERE faculty_id = {facultyId}";
            DatabaseHelper.Instance.Update(query);
        }
        public DataTable LoadDataGrid()
        {
            string query = $"Select admin_role_id,f.name as Faculty ,concat(s.term,' ',s.year) as Semester,f.faculty_id,s.semester_id,role_name From faculty_admin_roles natural join faculty f natural join semesters s";
            DataTable dt= DatabaseHelper.Instance.GetData(query);
            return dt;
        }
        public DataTable report()
        {
            string query = $"Select f.Name as Faculty, fr.role_name as Role,concat(s.Term,' ',s.Year) as Semester from faculty_admin_roles as fr natural join faculty as f natural join semesters s";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            return dt;
        }
    }
}
