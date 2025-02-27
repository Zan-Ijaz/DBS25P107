using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.BL;

namespace MidProjectDb.UI
{
    public class Facultyproject
    {
        public int facultyprojectid { get; set; }
        public int supervisionhours { get; set; }
        public int? facultyid{ get; set; }
        public int? projectid { get; set; }
        public int? semsterid { get; set; }

        public Faculty facultymember { get; set; }
        public Semester Semester { get; set; }
        public Project project { get; set; }
        public Facultyproject(int facultyprojectid, int supervisionhours, int? facultyid, int? projectid, int? semsterid, Faculty facultymember, Semester semester, Project project)
        {
            this.facultyprojectid = facultyprojectid;
            this.supervisionhours = supervisionhours;
            this.facultyid = facultyid;
            this.projectid = projectid;
            this.semsterid = semsterid;
            this.facultymember = facultymember;
            Semester = semester;
            this.project = project;
        }
    }
}
