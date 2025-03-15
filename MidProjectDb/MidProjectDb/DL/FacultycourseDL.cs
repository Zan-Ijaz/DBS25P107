using System;
using System.Collections.Generic;
using System.Data;
using MidProjectDb.BL;
using MidProjectDb.UI;
using Org.BouncyCastle.Asn1.Cmp;

namespace MidProjectDb.DL
{
    public class FacultyCourseDL
    {
        public DataTable GetDataTable()
        {
            string query = "SELECT * FROM faculty_courses";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            return dt;
        }

        public List<Facultycourse> GetData()
        {
            List<Facultycourse> facultyCourses = new List<Facultycourse>();
            string query = "SELECT * FROM faculty_courses";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int facultyCourseId = Convert.ToInt32(row["faculty_course_id"]);
                    int facultyId = Convert.ToInt32(row["faculty_id"]);
                    Faculty faculty = Faculty.findFaculty(facultyId);
                    int courseId = Convert.ToInt32(row["course_id"]);
                    Course course = Course.findCourse(courseId);
                    int semesterId = Convert.ToInt32(row["semester_id"]);
                    Semester sem = Semester.finSem(semesterId);
                    Facultycourse f = new Facultycourse(facultyCourseId, facultyId, courseId, semesterId,course,faculty,sem);
                    facultyCourses.Add(f);
                }
            }
            return facultyCourses;
        }

        public void InsertFacultyCourse(Facultycourse f)
        {
            string query = $"INSERT INTO faculty_courses (faculty_id, course_id, semester_id) VALUES ({f.facultyid}, {f.Courseid}, {f.Semesterid})";
            DatabaseHelper.Instance.Update(query);
        }

        public void DeleteFacultyCourse(int id)
        {
            string query = $"DELETE FROM faculty_courses WHERE faculty_course_id = {id}";
            DatabaseHelper.Instance.Update(query);
        }

        public void UpdateFacultyCourse(Facultycourse f)
        {
            string query = $"UPDATE faculty_courses SET faculty_id = {f.facultyid}, course_id = {f.Courseid}, semester_id = {f.Semesterid} WHERE faculty_course_id = {f.facultyCourseid}";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeletebySems(int id)
        {
            string query = $"DELETE FROM faculty_courses WHERE semester_id = {id}";
            DatabaseHelper.Instance.Update(query);
        }
        public void Deletebycourses(int id)
        {
            string query = $"DELETE FROM faculty_courses WHERE course_id = {id}";
            DatabaseHelper.Instance.Update(query);
        }
        public void Deletebyfaculty(int id)
        {
            string query = $"DELETE FROM faculty_courses WHERE faculty_id = {id}";
            DatabaseHelper.Instance.Update(query);
        }
        public DataTable loadDatagrid()
        {
            string query = $"SELECT faculty_course_id,f.name as Faculty,c.course_name as Course,concat(s.term,' ',s.year ) as Semester, f.faculty_id,c.course_id,s.semester_id FROM faculty_courses natural join faculty f natural join courses c natural join semesters s";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            return dt;
        }
    }
}
