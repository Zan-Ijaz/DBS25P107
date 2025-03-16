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
    public class FacultyprojectDL
    {
        public DataTable GetTable()
        {
            string query = "SELECT * FROM faculty_projects";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            return dt;
        }
        public List<Facultyproject> GetData()
        {
            List<Facultyproject> facultyProjects = new List<Facultyproject>();
            string query = "SELECT * FROM faculty_projects";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int facultyProjectId = Convert.ToInt32(row["faculty_project_id"]);
                    int facultyId = Convert.ToInt32(row["faculty_id"]);
                    Faculty faculty = Faculty.findFaculty(facultyId);
                    int projectId = Convert.ToInt32(row["project_id"]);
                    Project project = Project.findProject(projectId);
                    int semesterId = Convert.ToInt32(row["semester_id"]);
                    Semester sem = Semester.finSem(semesterId);
                    int supervisionHours = Convert.ToInt32(row["supervision_hours"]);
                    Facultyproject fp = new Facultyproject(facultyProjectId, supervisionHours, facultyId, projectId, semesterId, faculty, sem, project);
                    facultyProjects.Add(fp);
                }
            }
            return facultyProjects;
        }
        public void InsertFacultyProject(Facultyproject fp)
        {
            string query = $"INSERT INTO faculty_projects (faculty_id, project_id, semester_id, supervision_hours) VALUES ({fp.facultyid}, {fp.projectid}, {fp.semsterid}, {fp.supervisionhours})";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteFacultyProject(int id)
        {
            string query = $"DELETE FROM faculty_projects WHERE faculty_project_id = {id}";
            DatabaseHelper.Instance.Update(query);
        }
        public void UpdateFacultyProject(Facultyproject fp)
        {
            string query = $"UPDATE faculty_projects SET faculty_id = {fp.facultyid}, project_id = {fp.projectid}, semester_id = {fp.semsterid}, supervision_hours = {fp.supervisionhours} WHERE faculty_project_id = {fp.facultyprojectid}";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteBySemester(int semesterId)
        {
            string query = $"DELETE FROM faculty_projects WHERE semester_id = {semesterId}";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteByProject(int projectId)
        {
            string query = $"DELETE FROM faculty_projects WHERE project_id = {projectId}";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteByFaculty(int facultyId)
        {
            string query = $"DELETE FROM faculty_projects WHERE faculty_id = {facultyId}";
            DatabaseHelper.Instance.Update(query);
        }
        public DataTable LoadDataGrid()
        {
            string query = "SELECT fp.faculty_project_id, f.name AS Faculty, p.title AS Project, CONCAT(s.term, ' ', s.year) AS Semester, fp.supervision_hours as oldhrs ,fp.supervision_hours, fp.faculty_id ,f.faculty_id as oldfaculty_id, fp.project_id,p.project_id as oldproject_id, s.semester_id FROM faculty_projects fp NATURAL JOIN faculty f NATURAL JOIN projects p NATURAL JOIN semesters s";

            DataTable dt = DatabaseHelper.Instance.GetData(query);
            return dt;
        }
    }
}
