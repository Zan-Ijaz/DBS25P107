using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectDb.BL
{
    public enum SemesterTerm { Spring, Summer, Fall }

    public class Semester
    {
        public int SemesterId { get; set; }
        public SemesterTerm Term { get; set; } 
        public int Year { get; set; }
    }
}
