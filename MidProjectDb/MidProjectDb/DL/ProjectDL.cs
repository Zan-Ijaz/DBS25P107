using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.BL;
using MidProjectDb.UI;

namespace MidProjectDb.DL
{
    public class ProjectDL
    {
        public DataTable GetDataTable()
        {
            string query = $"Select * From projects";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            return dt;
        }
        public List<Project> getData()
        {
            List<Project> projects = new List<Project>();
            string query = $"Select * From projects";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int projectid = Convert.ToInt32(row["project_id"]);
                    string title = row["title"].ToString();
                    string description = row["description"].ToString();
                    Project p = new Project(projectid,title,description);
                    projects.Add(p);
                }
            }
            return projects;
        }
        public void insertProjects(Project p)
        {
            string query = $"Insert into projects(title,description) Values ('{p.titl}','{p.descreption}')";
            DatabaseHelper.Instance.Update(query);
        }

        public void deleteProject(int id)
        {
            string query = $"DELETE From projects WHERE project_id = {id}";
            DatabaseHelper.Instance.Update(query);
        }
        public void update(Project p)
        {
            string query = $"Update projects set title='{p.titl}',description='{p.descreption}' where project_id='{p.projectId}'";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
