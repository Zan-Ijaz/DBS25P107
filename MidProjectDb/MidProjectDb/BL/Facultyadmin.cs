using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.UI;

namespace MidProjectDb.BL
{
    public class FacultyAdminRole
    {
        public int AdminRoleId { get; set; }      
        public int? FacultyId { get; set; }     
        public string RoleName { get; set; }      
        public int? SemesterId { get; set; }              
        public Faculty Faculty { get; set; }     
        public Semester Semester { get; set; }    
    }
}
