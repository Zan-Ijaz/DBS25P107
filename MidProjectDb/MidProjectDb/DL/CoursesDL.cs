using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.BL;

namespace MidProjectDb.DL
{
    public class CoursesDL
    {
        public static List<Course> courses = new List<Course>();
        public static List<Course> getData()
        {
            List<Course> newcourses = new List<Course>();
            string query = $"Select * from courses";
            var reader = DatabaseHelper.Instance.getData(query);
            while(reader.Read())
            {
            int courseid = Convert.ToInt32(reader["course_id"]);
            string coursename = reader["course_name"].ToString();
            string courseType = reader["course_type"].ToString();
            int credithours = Convert.ToInt32(reader["credit_hours"]);
            int contacthours= Convert.ToInt32(reader["contact_hours"]);
            Course u = new Course(courseid, coursename, courseType, credithours, contacthours);
                newcourses.Add(u);
            }
            return newcourses;
        }
        public static void insertCourse(Course c)
        {
            string query = $"Insert into courses(course_name,course_type,credit_hours,contact_hours) Values ('{c.CourseName}','{c.CourseType}','{c.CreditHours}','{c.ContactHours}')";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
