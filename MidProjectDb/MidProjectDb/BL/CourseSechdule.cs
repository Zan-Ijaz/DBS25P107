using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.UI;
using MidProjectDb.DL;
using Mysqlx.Crud;
using Org.BouncyCastle.Cms;
using System.Runtime.Remoting.Messaging;

namespace MidProjectDb.BL
{
    public class CourseSechdule
    {
        public int Sechduleid { get; set; }
        public int facultycourseid { get; set; }
        public int roomid { get; set; }
        public Facultycourse facultycourse { get; set; }
        public Room room { get; set; }
        public string day { get; set; }
        public DateTime starttime { get; set; }
        public DateTime Endtime { get; set; }

        public CourseSechdule(int sechduleid, int facultycourseid, int roomid, Facultycourse facultycourse, Room room, string day, DateTime starttime, DateTime endtime)
        {
            Sechduleid = sechduleid;
            this.facultycourseid = facultycourseid;
            this.roomid = roomid;
            this.facultycourse = facultycourse;
            this.room = room;
            this.day = day;
            this.starttime = starttime;
            Endtime = endtime;
        }
        public CourseSechdule( int facultycourseid, int roomid, Facultycourse facultycourse, Room room, string day, DateTime starttime, DateTime endtime)
        {
            this.facultycourseid = facultycourseid;
            this.roomid = roomid;
            this.facultycourse = facultycourse;
            this.room = room;
            this.day = day;
            this.starttime = starttime;
            Endtime = endtime;
        }
        static CourseSechduleDL SechduleDL =new CourseSechduleDL();
        public static bool validation(CourseSechdule cs)
        {
            List<CourseSechdule> sechdules = SechduleDL.GetData();
            Facultycourse fc=Facultycourse.findfacultycourse(cs.facultycourseid);
            Faculty f = Faculty.findFaculty(fc.facultyid);
            Course c = Course.findCourse(fc.Courseid);
            if ((cs.Endtime - cs.starttime).TotalHours > c.ContactHours)
            {
                return false;
            }
            else
            {
                foreach (CourseSechdule courses in sechdules)
                {

                    Facultycourse facultycourse = Facultycourse.findfacultycourse(courses.facultycourseid);
                    Faculty faculty = Faculty.findFaculty(facultycourse.facultyid);
                    if (f.FacultyId == faculty.FacultyId && cs.day == courses.day && cs.day == courses.day && cs.starttime < courses.Endtime && cs.Endtime > courses.starttime)
                    {
                        return false;
                    }
                    if (cs.roomid == courses.roomid && cs.day == courses.day && cs.starttime < courses.Endtime && cs.Endtime > courses.starttime)
                    {
                        return false;
                    }
                    if (courses.facultycourseid == cs.facultycourseid)
                    {
                        double totalhours = (cs.Endtime - cs.starttime).TotalHours + (courses.Endtime - courses.starttime).TotalHours;
                        if (totalhours > c.ContactHours)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
        public static bool validation(CourseSechdule cs,int id)
        {
            List<CourseSechdule> sechdules = SechduleDL.GetData();
            Facultycourse fc = Facultycourse.findfacultycourse(cs.facultycourseid);
            Faculty f = Faculty.findFaculty(fc.facultyid);
            Course c = Course.findCourse(fc.Courseid);
            if ((cs.Endtime - cs.starttime).TotalHours > c.ContactHours)
            {
                return false;
            }
            else
            {
                foreach (CourseSechdule courses in sechdules)
                {

                    Facultycourse facultycourse = Facultycourse.findfacultycourse(courses.facultycourseid);
                    Faculty faculty = Faculty.findFaculty(facultycourse.facultyid);
                    if (id!=courses.Sechduleid&&f.FacultyId == faculty.FacultyId && cs.day == courses.day && cs.day == courses.day && cs.starttime < courses.Endtime && cs.Endtime > courses.starttime)
                    {
                        return false;
                    }
                    if (id != courses.Sechduleid && cs.roomid == courses.roomid && cs.day == courses.day && cs.starttime < courses.Endtime && cs.Endtime > courses.starttime)
                    {
                        return false;
                    }
                    if (id != courses.Sechduleid && courses.facultycourseid == cs.facultycourseid)
                    {
                        double totalhours = (cs.Endtime - cs.starttime).TotalHours + (courses.Endtime - courses.starttime).TotalHours;
                        if (totalhours > c.ContactHours)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
        public static bool addSechdule(CourseSechdule cs)
        {
            if (validation(cs))
            {
                SechduleDL.InsertCourseSechdule(cs);
                return true;
            }
            return false;
        }
        public static bool updateSechdule(CourseSechdule cs)
        {
            if (validation(cs, cs.Sechduleid))
            {
                SechduleDL.UpdateCourseSechdule(cs);
                return true;
            }
            return false;
        }
        public static void deleteSecdule(int id)
        {
            SechduleDL.DeleteCourseSechdule(id);
        }
        public static void deletebyfaccourse(int id)
        {
            SechduleDL.DeletebyFacultycourse(id);
        }
        public static void deletebyroom(int id)
        {
            SechduleDL.Deletebyroom(id);
        }
        public static List<CourseSechdule> getData()
        {
            List<CourseSechdule> sechdules = SechduleDL.GetData();
            return sechdules;
        }
    }
}
