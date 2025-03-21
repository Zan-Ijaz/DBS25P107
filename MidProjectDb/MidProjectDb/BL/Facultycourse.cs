using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.UI;
using MidProjectDb.DL;
namespace MidProjectDb.BL
{
    public class Facultycourse
    {
        public int facultyCourseid { get; set; }
        public int facultyid { get; set; }
        public int Courseid { get; set; }
        public int Semesterid { get; set; }

        public Course course { get; set; }
        public Faculty facultymember { get; set; }
        public Semester Semester { get; set; }
        public Facultycourse(int facultyCourseid, int facultyid, int courseid, int semesterid, Course course, Faculty facultymember, Semester semester)
        {
            this.facultyCourseid = facultyCourseid;
            this.facultyid = facultyid;
            Courseid = courseid;
            Semesterid = semesterid;
            this.course = course;
            this.facultymember = facultymember;
            Semester = semester;
        }
        public Facultycourse( int facultyid, int courseid, int semesterid, Course course, Faculty facultymember, Semester semester)
        {
            this.facultyCourseid = facultyCourseid;
            this.facultyid = facultyid;
            Courseid = courseid;
            Semesterid = semesterid;
            this.course = course;
            this.facultymember = facultymember;
            Semester = semester;
        }
        static FacultyCourseDL facultycoursesDL = new FacultyCourseDL();
        public static DataTable GetTable()
        {
            DataTable dt = facultycoursesDL.GetDataTable();
            return dt;
        }
        public static bool duplicationValidation(Facultycourse f)
        {
            List<Facultycourse> fcourses = facultycoursesDL.GetData();
            foreach(var fc in fcourses)
            {
                if (fc.Courseid == f.Courseid && fc.facultyid == f.facultyid && fc.Semesterid == f.Semesterid)
                {
                    return false;
                }
            }
                return true;

        }
        public static bool duplicationValidationupdate(Facultycourse f)
        {
            List<Facultycourse> fcourses = facultycoursesDL.GetData();
            foreach (var fc in fcourses)
            {
                if (fc.Courseid == f.Courseid && fc.facultyid == f.facultyid && fc.Semesterid == f.Semesterid&& fc.facultyCourseid!=f.facultyCourseid)
                {
                    return false;
                }
            }
            return true;
        }
        public static void DeleteFaccourse(int id)
        {
            CourseSechdule.deletebyfaccourse(id);
            facultycoursesDL.DeleteFacultyCourse(id);
        }
        public static Facultycourse findfacultycourse(int id)
        {
            List<Facultycourse> fcourses = facultycoursesDL.GetData();
            foreach(var fc in fcourses)
            {
                if (fc.facultyCourseid == id)
                {
                    return fc;
                }
            }
            return null;
        }
        public static void DeletebyFac(int id)
        {
            facultycoursesDL.Deletebyfaculty(id);
        }
        public static void Deletebycourses(int id)
        {
            facultycoursesDL.Deletebycourses(id);
        }
        public static void DeletebySem(int id)
        {
            facultycoursesDL.DeletebySems(id);
        }
        public static bool addFacultyCourse(Facultycourse fc)
        {
            if (duplicationValidation(fc))
            {
                int remainghours = 0;
                Faculty faculty = Faculty.findFaculty(fc.facultyid);
                int totalteaching = faculty.totalteaching();
                Course Course = Course.findCourse(fc.Courseid);
                remainghours = faculty.TotalTeachingHours-(Course.ContactHours+totalteaching);
                if (remainghours>=0)
                {
                    facultycoursesDL.InsertFacultyCourse(fc);
                    return true;
                }
                return false;
            }
            return false;
        }
        public static bool updatefacultycourse(Facultycourse fc,int oldcourseid,int oldfacultyid)
        {
            if(duplicationValidationupdate(fc))
            {

                int remainghours = 0;
                Faculty newfaculty = Faculty.findFaculty(fc.facultyid);
                int totalteaching = newfaculty.totalteaching();
                Course newCourse = Course.findCourse(fc.Courseid);
                remainghours = newfaculty.TotalTeachingHours - (newCourse.ContactHours + totalteaching);
                if (remainghours >= 0)
                {
                    facultycoursesDL.UpdateFacultyCourse(fc);
                    return true;
                }
                return false;
            }
            return false;
        }
        public static DataTable DatagridTable()
        {
            DataTable dt = facultycoursesDL.loadDatagrid();
            return dt;
        }
        public static List<Facultycourse> getList()
        {
            List<Facultycourse> fcourses = facultycoursesDL.GetData();
            return fcourses;
        }
    }
}
