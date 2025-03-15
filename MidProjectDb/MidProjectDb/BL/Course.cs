using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using MidProjectDb.DL;

namespace MidProjectDb.BL
{

    public class Course
    {
       
            public int CourseId { get; set; }
            public string CourseName { get; set; } 
            public string CourseType { get; set; }  
            public int CreditHours { get; set; }    
            public int ContactHours { get; set; }   
        public Course(int courseId, string courseName, string courseType, int creditHours, int contactHours)
        {
            CourseId = courseId;
            CourseName = courseName;
            CourseType = courseType;
            CreditHours = creditHours;
            ContactHours = contactHours;
        }
        public Course( string courseName, string courseType, int creditHours, int contactHours)
        {
            CourseName = courseName;
            CourseType = courseType;
            CreditHours = creditHours;
            ContactHours = contactHours;
        }
        public static bool courseduplication(string title)
        {
            List<Course> courses = getData();
            foreach (var c in courses)
            {
                if (c.CourseName.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool courseduplication(string title,int id)
        {
            List<Course> courses=getData();
            foreach (var c in courses)
            {
                if (c.CourseName.Equals(title, StringComparison.OrdinalIgnoreCase) && c.CourseId!=id)
                {
                    return false;
                }
            }
            return true;
        }
        public static void insert(Course c)
        {
            CoursesDL courseDLobj = new CoursesDL();
            courseDLobj.insertCourse(c);

        }
        public static List<Course> getData()
        {
            CoursesDL courseDLobj = new CoursesDL();
            List<Course> courses = courseDLobj.getData();
            return courses;
        }
        public static DataTable getTable()
        {
            CoursesDL courseDLobj = new CoursesDL();
            DataTable dt = courseDLobj.GetDataTable();
            return dt;
        }
        public static void deleteCourse(int id)
        {
            CoursesDL courseDLobj = new CoursesDL();
            Facultycourse.Deletebycourses(id);
            courseDLobj.deleteCourse(id);
        }
        public static void update(Course c)
        {
            CoursesDL courseDLobj = new CoursesDL();
            courseDLobj.update(c);
        }
        public static Course findCourse(int id)
        {
            List<Course> courses = getData();
            foreach(var c in courses)
            {
                if (id == c.CourseId)
                {
                    return c;
                }
            }
            return null;
        }
        public static Course findCourse(string name)
        {
            List<Course> courses = getData();
            foreach (var c in courses)
            {
                if (name == c.CourseName)
                {
                    return c;
                }
            }
            return null;
        }
    }
}
