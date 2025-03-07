using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            List<Course> courses = CoursesDL.getData();
            foreach(var c in courses)
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
            List<Course> courses = CoursesDL.getData();
            foreach (var c in courses)
            {
                if (c.CourseName.Equals(title, StringComparison.OrdinalIgnoreCase) && c.CourseId!=id)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
