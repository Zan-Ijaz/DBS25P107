using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectDb.UI
{
    public class Faculty
    {
        public int FacultyId { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }   
        public string Contact { get; set; }
        public string ResearchArea { get; set; }
        public int? TotalTeachingHours { get; set; }

        public int? UserId { get; set; }    
        public User FacultyUser { get; set; }

    }
}
