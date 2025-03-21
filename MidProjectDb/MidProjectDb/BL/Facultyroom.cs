using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.UI;
using MidProjectDb.DL;

namespace MidProjectDb.BL
{
    public class Facultyroom
    {
        public int allocationid { get; set; }
        public int reservedHours { get;set; }
        public int facultyid { get;set; }
        public int roomid { get; set; }
        public int semesterid { get; set; }
        public Faculty faculty { get; set; }
        public Room room { get; set; }
        public Semester semester { get; set; }
        public Facultyroom(int allocationid, int reservedHours, int facultyid, int roomid, int semesterid, Faculty faculty, Room room, Semester semester)
        {
            this.allocationid = allocationid;
            this.reservedHours = reservedHours;
            this.facultyid = facultyid;
            this.roomid = roomid;
            this.semesterid = semesterid;
            this.faculty = faculty;
            this.room = room;
            this.semester = semester;
        }
        public Facultyroom( int reservedHours, int facultyid, int roomid, int semesterid, Faculty faculty, Room room, Semester semester)
        {
            this.reservedHours = reservedHours;
            this.facultyid = facultyid;
            this.roomid = roomid;
            this.semesterid = semesterid;
            this.faculty = faculty;
            this.room = room;
            this.semester = semester;
        }
        static FacultyroomDL facultyroomDLobj = new FacultyroomDL();
        public static bool validation(Facultyroom fr)
        {
            List<Facultyroom> facultyrooms = facultyroomDLobj.GetData();
            foreach(var room in facultyrooms)
            {
                if (fr.facultyid == room.facultyid && room.roomid == fr.roomid && fr.semesterid == room.semesterid)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool validation(Facultyroom fr,int id)
        {
            List<Facultyroom> facultyrooms = facultyroomDLobj.GetData();
            foreach (var room in facultyrooms)
            {
                if (fr.facultyid == room.facultyid && room.roomid == fr.roomid && fr.semesterid == room.semesterid&&id!=room.allocationid)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool add(Facultyroom fr)
        {
            if (validation(fr) && fr.reservedHours > 0)
            {
                facultyroomDLobj.InsertFacultyRoom(fr);
                return true;
            }
            return false;
        }
        public static bool update(Facultyroom fr)
        {
            if (validation(fr,fr.allocationid) && fr.reservedHours > 0)
            {
                facultyroomDLobj.UpdateFacultyRoom(fr);
                return true;
            }
            return false;
        }
        public static void delete(int id)
        {
            facultyroomDLobj.DeleteFacultyRoom(id);
        }
        public static void deletebyfac(int id)
        {
            facultyroomDLobj.DeleteByFaculty(id);
        }
        public static void deletebyroom(int id)
        {
            facultyroomDLobj.DeleteByRoom(id);
        }
        public static void deletebySem(int id)
        {
            facultyroomDLobj.DeleteBySemester(id);
        }
    }
}
