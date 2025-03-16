using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.DL;
using MidProjectDb.UI;

namespace MidProjectDb.BL
{
    public class Semester
    {
        public int SemesterId { get; set; }
        public string Term { get; set; } 
        public int Year { get; set; }
        public Semester(int semesterId, string term, int year)
        {
            SemesterId = semesterId;
            Term = term;
            Year = year;
        }
        public Semester( string term, int year)
        {
            Term = term;
            Year = year;
        }
        public static SemesterDL semsters = new SemesterDL();
        public static bool semsterValidation(Semester s)//When adding
        {
            List<Semester> sems = semsters.GetData();
            if (sems != null)
            {
                foreach(var sem in sems)
                {
                    if(s.Term==sem.Term && s.Year == sem.Year && (sem.Year < 2000 || sem.Year < DateTime.Now.Year + 1))
                    {
                        return false;
                    }
                }
                return true;
            }
            return true;
        }
        public static bool semsterValidation(Semester s,int id)//Whsen updateing
        {
            List<Semester> sems = semsters.GetData();
            if (sems != null)
            {
                foreach (var sem in sems)
                {
                    if (s.Term == sem.Term && s.Year == sem.Year && (sem.Year < 2000 || sem.Year < DateTime.Now.Year + 1) && s.SemesterId!=sem.SemesterId)
                    {
                        return false;
                    }
                }
                return true;
            }
            return true;
        }
        public static bool update(Semester s)
        {
            if(semsterValidation(s,s.SemesterId))
            {
                semsters.UpdateSemester(s);
                return true;
            }
            return false;
        }
        public static bool addSem(Semester s)
        {
            if (semsterValidation(s))
            {
                semsters.InsertSemester(s);
                return true;
            }
            return false;
        }
        public static void deleteSem(int id)
        {
            Facultycourse.DeletebySem(id);
            Facultyproject.DeletebySem(id);
            Facultyadmin.deletebysem(id);
            semsters.DeleteSemester(id);
        }
        public static DataTable GetTable()
        {
            DataTable dt = semsters.GetDataTable();
            return dt;

        }
        public static Semester findSem(int id)
        {
            List<Semester> sems = semsters.GetData();
            foreach(var s in sems)
            {
                if (s.SemesterId == id)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
