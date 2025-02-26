using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.UI;

namespace MidProjectDb.BL
{
    public class Facultyroom
    {
        public int allocationid { get; set; }
        public int reservedHours { get;set; }
        public int? facultyid { get;set; }
        public int? roomid { get; set; }
        public int? semesterid { get; set; }

        public Faculty faculty { get; set; }
        public Room room { get; set; }
        public Semester semester { get; set; }

    }
}
