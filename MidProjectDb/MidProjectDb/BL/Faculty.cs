using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.BL;
using MidProjectDb.DL;

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
        public int? DesignationId { get; set; }
        public User FacultyUser { get; set; }
        public Lookup designation { get; set; }
        public Faculty(int facultyId, string name, string email, string contact, string researchArea, int? totalTeachingHours, int? userId, int? designationId,User user,Lookup Designation)
        {
            FacultyId = facultyId;
            Name = name;
            Email = email;
            Contact = contact;
            ResearchArea = researchArea;
            TotalTeachingHours = totalTeachingHours;
            UserId = userId;
            DesignationId = designationId;
            FacultyUser = user;
            this.designation = Designation;
        }
        public Faculty( string name, string email, string contact, string researchArea, int? totalTeachingHours, int? userId, int? designationId)
        {
            Name = name;
            Email = email;
            Contact = contact;
            ResearchArea = researchArea;
            TotalTeachingHours = totalTeachingHours;
            UserId = userId;
            DesignationId = designationId;
            this.designation = designation;
        }
        public static bool numberdup(string number)
        {
            List<Faculty> faculty = FacultyDL.getData();
            foreach(var member in faculty)
            {
                if (number == member.Contact)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool numberdup(string number,int id)
        {
            List<Faculty> faculty = FacultyDL.getData();
            foreach (var member in faculty)
            {
                if (number == member.Contact && member.UserId!=id)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
