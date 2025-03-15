using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
        public int TotalTeachingHours { get; set; }
        public int UserId { get; set; }    
        public int? DesignationId { get; set; }
        public User FacultyUser { get; set; }
        public Lookup designation { get; set; }
        public Faculty(int facultyId, string name, string email, string contact, string researchArea, int totalTeachingHours, int userId, int? designationId,User user,Lookup Designation)
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
        public Faculty( string name, string email, string contact, string researchArea, int totalTeachingHours, int userId, int? designationId)
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
            FacultyDL facultyDLobject = new FacultyDL();
            List<Faculty> faculty = facultyDLobject.getData();
            if(faculty.Count > 0)
            {
                foreach (var member in faculty)
                {
                    if (number == member.Contact)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool numberdup(string number,int id)
        {
            FacultyDL facultyDLobject = new FacultyDL();
            List<Faculty> faculty = facultyDLobject.getData();
            if(faculty.Count > 0)
            {
                foreach (var member in faculty)
                {
                    if (number == member.Contact && member.UserId != id)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static void delete(int id)
        {
            FacultyDL facultyDLobject = new FacultyDL();
            Facultycourse.DeletebyFac(id);
            facultyDLobject.Delete(id);
        }
        public static void insert(Faculty u)
        {
            FacultyDL facultyDLobject = new FacultyDL();
            facultyDLobject.insertfaculty(u);
        }
        public static void update(Faculty u)
        {
            FacultyDL facultyDLobject = new FacultyDL();
            facultyDLobject.update(u);
        }
        public static bool validationsCheck(Faculty u, out string errorMessage)
        {

            if (!Utility.Utility.intValidatioin(u.Contact))
            {
                errorMessage = "Invalid phone number format.\n";
                return   false;
            }
            else if (!Faculty.numberdup(u.Contact, u.UserId))
            {
                errorMessage = "Phone number already exists.\n";
                return false;
            }
            if (!Utility.Utility.stringvalidation(u.ResearchArea))
            {
                errorMessage = "Invalid research area format.\n";
                return false;
            }
            errorMessage = "User added";
            return true;

        }
        public static DataTable GetTable()
        {
            FacultyDL facultyDLobject = new FacultyDL();
            DataTable dt=facultyDLobject.GetTable();
            return dt;
        }
        public static Faculty findFaculty(int id)
        {
            FacultyDL facultyDLobject = new FacultyDL();
            List<Faculty> faculty = facultyDLobject.getData();
            foreach(var f in faculty)
            {
                if (id == f.FacultyId)
                {
                    return f;
                }
            }
            return null;
        }


    }
}
