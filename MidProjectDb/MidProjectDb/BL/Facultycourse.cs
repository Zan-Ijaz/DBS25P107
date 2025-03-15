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
        public static bool DeleteFaccourse(int id)
        {
            Facultycourse facultycourse = findfacultycourse(id);
            if (facultycourse != null)
            {
                Faculty faculty = Faculty.findFaculty(facultycourse.facultyid);
                Course Course = Course.findCourse(facultycourse.Courseid);
                faculty.TotalTeachingHours += Course.ContactHours;//adding the hours back which were taken 
                facultycoursesDL.DeleteFacultyCourse(facultycourse.facultyCourseid);
                Faculty.update(faculty);
                return true;
            }
            return false;
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
            DataTable dt = Facultycourse.GetTable();
            if (dt != null)
            {
                Course c = Course.findCourse(id);
                foreach(DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr["course_id"]) == id)
                    {
                        Faculty f = Faculty.findFaculty(Convert.ToInt32(dr["faculty_id"]));
                        f.TotalTeachingHours += c.ContactHours;
                        Faculty.update(f);
                    }
                }
            }
            facultycoursesDL.Deletebycourses(id);
        }
        public static void DeletebySem(int id)
        {

            DataTable dt = Facultycourse.GetTable();
            if (dt != null)
            {
                Semester s = Semester.finSem(id);
                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToInt32(dr["semester_id"]) == id)
                    {
                        Course c = Course.findCourse(Convert.ToInt32(dr["course_id"]));
                        Faculty f = Faculty.findFaculty(Convert.ToInt32(dr["faculty_id"]));
                        f.TotalTeachingHours += c.ContactHours;
                        Faculty.update(f);
                    }
                }
            }
            facultycoursesDL.DeletebySems(id);
        }
        public static bool addFacultyCourse(Facultycourse fc)
        {
            if (duplicationValidation(fc))
            {
                int remainghours = 0;
                Faculty faculty = Faculty.findFaculty(fc.facultyid);
                Course Course = Course.findCourse(fc.Courseid);
                remainghours = faculty.TotalTeachingHours-Course.ContactHours;
                if (remainghours>=0)
                {
                    faculty.TotalTeachingHours -= Course.ContactHours;
                    facultycoursesDL.InsertFacultyCourse(fc);
                    Faculty.update(faculty);
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
                int Contacthrs = 0;
                int remainghours = 0;
                Faculty newfaculty = Faculty.findFaculty(fc.facultyid);
                Course newCourse = Course.findCourse(fc.Courseid);
                if (newCourse.CourseId != oldcourseid)
                {
                    Course oldCourse = Course.findCourse(oldcourseid);
                    Contacthrs = oldCourse.ContactHours;
                }
                else
                {
                    Contacthrs = newCourse.ContactHours;
                }
                if (newfaculty.FacultyId != oldfacultyid)
                {
                    Faculty oldfaculty = Faculty.findFaculty(oldfacultyid);
                    oldfaculty.TotalTeachingHours += Contacthrs;
                    Faculty.update(oldfaculty);
                }
                else
                {
                    newfaculty.TotalTeachingHours += Contacthrs;
                }
                remainghours = newfaculty.TotalTeachingHours - newCourse.ContactHours;
                if (remainghours >= 0)
                {
                    newfaculty.TotalTeachingHours -= newCourse.ContactHours;
                    facultycoursesDL.UpdateFacultyCourse(fc);
                    Faculty.update(newfaculty);
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
    }
}
