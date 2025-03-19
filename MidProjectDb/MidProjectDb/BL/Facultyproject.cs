using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using MidProjectDb.BL;
using MidProjectDb.DL;
using Mysqlx.Crud;

namespace MidProjectDb.UI
{
    public class Facultyproject
    {
        public int facultyprojectid { get; set; }
        public int supervisionhours { get; set; }
        public int facultyid{ get; set; }
        public int projectid { get; set; }
        public int semsterid { get; set; }

        public Faculty facultymember { get; set; }
        public Semester Semester { get; set; }
        public Project project { get; set; }
        public Facultyproject(int facultyprojectid, int supervisionhours, int facultyid, int projectid, int semsterid, Faculty facultymember, Semester semester, Project project)
        {
            this.facultyprojectid = facultyprojectid;
            this.supervisionhours = supervisionhours;
            this.facultyid = facultyid;
            this.projectid = projectid;
            this.semsterid = semsterid;
            this.facultymember = facultymember;
            Semester = semester;
            this.project = project;
        }
        public Facultyproject( int supervisionhours, int facultyid, int projectid, int semsterid, Faculty facultymember, Semester semester, Project project)
        {
            this.facultyprojectid = facultyprojectid;
            this.supervisionhours = supervisionhours;
            this.facultyid = facultyid;
            this.projectid = projectid;
            this.semsterid = semsterid;
            this.facultymember = facultymember;
            Semester = semester;
            this.project = project;
        }
        static FacultyprojectDL FacultyprojectDLobj = new FacultyprojectDL();
        public static bool validationupdate (Facultyproject fp,int id)
        {
            List<Facultyproject> facultyprojects = FacultyprojectDLobj.GetData();
            foreach (var project in facultyprojects)
            {
                if (fp.projectid == project.projectid && fp.facultyid == project.facultyid && fp.semsterid == project.semsterid&&id!= fp.facultyprojectid && fp.supervisionhours > 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool validation(Facultyproject fp)
        {
            List<Facultyproject> facultyprojects = FacultyprojectDLobj.GetData();
            foreach (var project in facultyprojects)
            {
                if (fp.projectid == project.projectid && fp.facultyid == project.facultyid && fp.semsterid == project.semsterid &&fp.supervisionhours>0)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool update(Facultyproject fp, int oldfac, int oldsuperhrs)
        {
            if (validationupdate(fp, fp.facultyprojectid))
            {
                Faculty f = Faculty.findFaculty(fp.facultyid);
                int totalteaching = f.totalteaching();
                int remaing = f.TotalTeachingHours - (totalteaching + fp.supervisionhours);
                if(remaing>=0)
                {
                    FacultyprojectDLobj.UpdateFacultyProject(fp);
                    return true;
                }
            }
            return false;
        }
        public static bool add(Facultyproject fp)
        {
            if (validation(fp))
            {
                Faculty f = Faculty.findFaculty(fp.facultyid);
                int totalteaching = f.totalteaching();
                int remaing = f.TotalTeachingHours - (totalteaching + fp.supervisionhours);
                if (remaing >= 0)
                {
                    FacultyprojectDLobj.InsertFacultyProject(fp);
                    return true;
                }
                return false;
            }
            return false;
        }
        public static void delete(int id)
        {
            FacultyprojectDLobj.DeleteFacultyProject(id);
        }
        public static void DeletebySem(int id)
        {
            
                FacultyprojectDLobj.DeleteBySemester(id);
        }
        public static void DeletebyProject(int id)
        {
            FacultyprojectDLobj.DeleteByProject(id);
        }
        public static void DeletebyFaculty(int id)
        {
            DataTable dt = FacultyprojectDLobj.GetTable();
            if (dt != null)
            {
                    FacultyprojectDLobj.DeleteByFaculty(id);
            }
        }
        public static Facultyproject findfacultyproject(int id)
        {
            List<Facultyproject> facultyprojects = FacultyprojectDLobj.GetData();
            foreach(var fp in facultyprojects)
            {
                if (id == fp.facultyprojectid)
                {
                    return fp;
                }
            }
            return null;
        }
        public static DataTable DataGridTable()
        {
            DataTable dt = FacultyprojectDLobj.LoadDataGrid();
            return dt;
        }
    }
}
