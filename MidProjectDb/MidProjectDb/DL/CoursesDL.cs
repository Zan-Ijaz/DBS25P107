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
        public List<Course> getData()
        {
            List<Course> newcourses = new List<Course>();
            string query = $"Select * from courses";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int courseid = Convert.ToInt32(row["course_id"]);
                    string coursename = row["course_name"].ToString();
                    string courseType = row["course_type"].ToString();
                    int credithours = Convert.ToInt32(row["credit_hours"]);
                    int contacthours = Convert.ToInt32(row["contact_hours"]);
                    Course u = new Course(courseid, coursename, courseType, credithours, contacthours);
                    newcourses.Add(u);
                }
            }
            return newcourses;
        }
        public DataTable GetDataTable()
        {
            string query = $"Select * from courses";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            return dt;
        }
        public void insertCourse(Course c)
        {
            string query = $"Insert into courses(course_name,course_type,credit_hours,contact_hours) Values ('{c.CourseName}','{c.CourseType}','{c.CreditHours}','{c.ContactHours}')";
            DatabaseHelper.Instance.Update(query);
        }
        public void deleteCourse(int id)
        {
            string query = $"DELETE FROM courses WHERE course_id = {id}";
            DatabaseHelper.Instance.Update(query);
        }
        public void update(Course c)
        {
            string query = $"Update courses set course_name='{c.CourseName}',course_type='{c.CourseType}',credit_hours='{c.CreditHours}',contact_hours='{c.ContactHours}' where course_id='{c.CourseId}'";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
