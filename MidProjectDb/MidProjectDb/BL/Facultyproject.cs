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
                if (oldfac != fp.facultyid)
                {
                    Faculty oldf = Faculty.findFaculty(oldfac);
                    oldf.TotalTeachingHours += oldsuperhrs;
                    Faculty.update(oldf);
                }
                else
                {
                    Faculty newf = Faculty.findFaculty(fp.facultyid);
                    newf.TotalTeachingHours += oldsuperhrs;
                    Faculty.update(newf);
                }
                Faculty f = Faculty.findFaculty(fp.facultyid);
                int remainhrs = f.TotalTeachingHours - fp.supervisionhours;
                if (remainhrs >= 0)
                {
                    f.TotalTeachingHours -= fp.supervisionhours;
                    FacultyprojectDLobj.UpdateFacultyProject(fp);
                    Faculty.update(f);
                }
                else
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        public static bool add(Facultyproject fp)
        {
            if (validation(fp))
            {
                Faculty f = Faculty.findFaculty(fp.facultyid);
                int remainghrs = f.TotalTeachingHours-fp.supervisionhours;
                if (remainghrs >= 0)
                {
                    f.TotalTeachingHours -= fp.supervisionhours;
                    Faculty.update(f);
                    FacultyprojectDLobj.InsertFacultyProject(fp);
                    return true;
                }
                return false;
            }
            return false;
        }
        public static void delete(int id)
        {
            Facultyproject fp = findfacultyproject(id);
            Faculty f = Faculty.findFaculty(fp.facultyid);
            f.TotalTeachingHours += fp.supervisionhours;
            Faculty.update(f);
            FacultyprojectDLobj.DeleteFacultyProject(fp.facultyprojectid);
        }
        public static void DeletebySem(int id)
        {
            DataTable dt = FacultyprojectDLobj.GetTable();
            if (dt != null)
            {
                Semester s = Semester.findSem(id);
                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr["semester_id"]) == id)
                    {
                        Faculty f = Faculty.findFaculty(Convert.ToInt32(dr["faculty_id"]));
                        f.TotalTeachingHours += Convert.ToInt32(dr["supervision_hours"]);
                        Faculty.update(f);
                    }
                }
                FacultyprojectDLobj.DeleteBySemester(id);
            }
        }
        public static void DeletebyProject(int id)
        {
            DataTable dt = FacultyprojectDLobj.GetTable();
            if (dt != null)
            {
                Project p = Project.findProject(id);
                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr["project_id"]) == id)
                    {
                        Faculty f = Faculty.findFaculty(Convert.ToInt32(dr["faculty_id"]));
                        f.TotalTeachingHours += Convert.ToInt32(dr["supervision_hours"]);
                        Faculty.update(f);
                    }
                }
                FacultyprojectDLobj.DeleteByProject(id);
            }
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
