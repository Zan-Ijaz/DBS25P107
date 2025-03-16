using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.DL;

namespace MidProjectDb.UI
{
    public class Project
    {
        public int projectId { get; set; }
        public string descreption { get; set; }
        public string titl { get; set; }
        public Project(int projectId, string titl, string descreption)
        {
            this.projectId = projectId;
            this.titl = titl;
            this.descreption = descreption;
        }
        public Project( string titl, string descreption)
        {
            this.titl = titl;
            this.descreption = descreption;
        }
        public static ProjectDL projects = new ProjectDL();
        public static bool addProject(Project p)
        {
            if (projectValidation(p) && titlevalidation(p.titl))
            {
            projects.insertProjects(p);
                return true;
            }
            return false;
        }
        public static void deleteProject(int id)
        {
            projects.deleteProject(id);
            Facultyproject.DeletebyProject(id);
        }
        public static bool Updateproject(Project p)
        {
            if(projectValidation(p) && titlevalidation(p.titl,p.projectId) )
            {
                projects.update(p);
                return true;
            }
            return false;
        }
        public static DataTable GetTable()
        {
            DataTable dt = projects.GetDataTable();
            return dt;
        }
        public static bool titlevalidation(string title,int id)
        {
            List<Project> projectslist = projects.getData();
            if(projectslist!=null)
            {
                foreach (var project in projectslist)
                {
                    if(project.titl==title && project.projectId != id)
                    {
                        return false;
                    }
                }
                return true;
            }
            return true;
        }
        public static bool titlevalidation(string title)
        {
            List<Project> projectslist = projects.getData();
            if (projectslist != null)
            {
                foreach (var project in projectslist)
                {
                    if (project.titl == title )
                    {
                        return false;
                    }
                }
                return true;
            }
            return true;
        }
        public static bool projectValidation(Project p)
        {
            if(Utility.Utility.stringvalidation(p.titl)&& Utility.Utility.stringvalidation(p.descreption))
            {
                return true;
            }
            return false;
        }
        public static Project findProject(int id)
        {
            List<Project> projectslist = projects.getData();
            foreach(var p in projectslist)
            {
                if (id == p.projectId)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
