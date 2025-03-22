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
            Facultyproject.DeletebyFaculty(id);
            Facultyadmin.deletebyfac(id);
            FacultyReq.deletebyfac(id);
            Facultyroom.deletebyfac(id);
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
        public static Faculty findFaculty(string email)
        {
            FacultyDL facultyDLobject = new FacultyDL();
            List<Faculty> faculty = facultyDLobject.getData();
            foreach (var f in faculty)
            {
                if (email == f.Email)
                {
                    return f;
                }
            }
            return null;
        }
        public static List<Faculty> getList()
        {
            FacultyDL facultyDLobject = new FacultyDL();
            List<Faculty> faculty = facultyDLobject.getData();
            return faculty;
        }
        public int totalteaching()
        {
            int hrs=0;
            List<Facultycourse> courses = Facultycourse.getList();
            foreach(var c in courses)
            {
                if (c.facultyid == this.FacultyId)
                {
                    hrs += c.course.ContactHours;
                }
            }
            List<Facultyproject> projects = new List<Facultyproject>();
            foreach(var p in projects)
            {
                if (p.facultyid == this.FacultyId)
                {
                    hrs += p.supervisionhours;
                }
            }
            return hrs;
        }
        public static DataTable report()
        {
            FacultyDL facultyDLobject = new FacultyDL();
            DataTable dt = facultyDLobject.report();
            return dt;
        }

    }
}
