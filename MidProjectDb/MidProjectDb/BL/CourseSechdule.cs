using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.UI;

namespace MidProjectDb.BL
{
    public enum day { Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday}
    public class CourseSechdule
    {
        public int Sechduleid { get; set; }
        public int? facultycourseid { get; set; }
        public int? roomid { get; set; }
        public Facultycourse facultycourse { get; set; }
        public Room room { get; set; }
        public day day { get; set; }
        public DateTime starttime { get; set; }
        public DateTime Endtime { get; set; }
    }
}
