using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.DL;
using MidProjectDb.UI;

namespace MidProjectDb.BL
{
    public class Facultyadmin
    {
        public int AdminRoleId { get; set; }      
        public int FacultyId { get; set; }     
        public string RoleName { get; set; }      
        public int SemesterId { get; set; }              
        public Faculty Faculty { get; set; }     
        public Semester Semester { get; set; } 
        public Facultyadmin(int adminRoleId, int facultyId, string roleName, int semesterId, Faculty faculty, Semester semester)
        {
            AdminRoleId = adminRoleId;
            FacultyId = facultyId;
            RoleName = roleName;
            SemesterId = semesterId;
            Faculty = faculty;
            Semester = semester;
        }
        public Facultyadmin( int facultyId, string roleName, int semesterId, Faculty faculty, Semester semester)
        {
            FacultyId = facultyId;
            RoleName = roleName;
            SemesterId = semesterId;
            Faculty = faculty;
            Semester = semester;
        }
        static FacultyadminDL adminRoleDL = new FacultyadminDL();
        public static bool validation(Facultyadmin ar)
        {
            List<Facultyadmin> adminroles = adminRoleDL.GetData();
            foreach(var roles in adminroles)
            {
                if(Utility.Utility.stringvalidation(ar.RoleName)&&roles.SemesterId == ar.SemesterId && roles.FacultyId == ar.FacultyId && roles.RoleName == ar.RoleName)
                {
                    return false;
                }
            }
            return true;
        }
        public static List<Facultyadmin> getData()
        {
            return adminRoleDL.GetData();
        }
        public static bool validation(Facultyadmin ar,int id)
        {
            List<Facultyadmin> adminroles = adminRoleDL.GetData();
            foreach (var roles in adminroles)
            {
                if (Utility.Utility.stringvalidation(ar.RoleName)&&roles.SemesterId == ar.SemesterId && roles.FacultyId == ar.FacultyId && roles.RoleName == ar.RoleName&&id!=roles.AdminRoleId)
                {
                    return false;
                }
            }
            return true;
        }
        public static DataTable loadGrid()
        {
            DataTable dt=adminRoleDL.LoadDataGrid();
            return dt;
        }
        public static void deletebyfac(int id)
        {
            adminRoleDL.DeleteByFaculty(id);
        }
        public static void deletebysem(int id)
        {
            adminRoleDL.DeleteBySem(id);
        }
        public static void delete(int id)
        {
            adminRoleDL.DeleteFacultyAdminRole(id);
        }
        public static bool update(Facultyadmin ar)
        {
            if (validation(ar, ar.AdminRoleId))
            {
               adminRoleDL.UpdateFacultyAdminRole(ar);
               return true;
            }
            return false;
        }
        public static bool add(Facultyadmin ar)
        {
            if (validation(ar))
            {
               adminRoleDL.InsertFacultyAdminRole(ar);
               return true;
            }
            return false;
        }
        public static DataTable report()
        {
            return adminRoleDL.report();
        }
    }
}
