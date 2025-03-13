using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.BL;

namespace MidProjectDb.DL
{
    public class SemesterDL
    {
        public DataTable GetDataTable()
        {
            string query = "select * from semesters";
            DataTable dt=DatabaseHelper.Instance.GetData(query);
            return dt;
        }
        public List<Semester> GetData()
        {
            List<Semester> semesters = new List<Semester>();
            DataTable dt = GetDataTable();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int semesterId = Convert.ToInt32(row["semester_id"]);
                    string term = row["term"].ToString();
                    int year = Convert.ToInt32(row["year"]);
                    Semester s = new Semester(semesterId, term, year);
                    semesters.Add(s);
                }
            }
            return semesters;
        }
        public void InsertSemester(Semester semester)
        {
            string query = $"insert into semesters (term, year) VALUES ('{semester.Term}', {semester.Year})";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteSemester(int id)
        {
            string query = $"delete from semesters where semester_id = {id}";
            DatabaseHelper.Instance.Update(query);
        }
        public void UpdateSemester(Semester semester)
        {
            string query = $"update semesters set term = '{semester.Term}', year = {semester.Year} where semester_id = {semester.SemesterId}";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
