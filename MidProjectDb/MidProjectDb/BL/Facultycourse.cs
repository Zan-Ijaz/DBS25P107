using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.UI;

namespace MidProjectDb.BL
{
    public class Facultycourse
    {
        public int facultyCourseid { get; set; }
        public int? facultyid { get; set; }
        public int? Courseid { get; set; }
        public int? Semesterid { get; set; }

        public Course course { get; set; }
        public Faculty facultymember { get; set; }
        public Semester Semester { get; set; }
    }
}
