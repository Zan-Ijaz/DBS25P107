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
    public class FacultyroomDL
    {
      
        public List<Facultyroom> GetData()
        {
            List<Facultyroom> allocations = new List<Facultyroom>();
            string query = "SELECT * from faculty_room_allocation";
            DataTable dt = DatabaseHelper.Instance.GetData(query);

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int allocationid = Convert.ToInt32(row["allocation_id"]);
                    int reservedHours = Convert.ToInt32(row["reserved_hours"]);
                    int facultyid = Convert.ToInt32(row["faculty_id"]);
                    int roomid = Convert.ToInt32(row["room_id"]);
                    int semesterid = Convert.ToInt32(row["semester_id"]);
                    Faculty faculty = Faculty.findFaculty(facultyid);
                    Room room = Room.findroom(roomid);
                    Semester semester = Semester.findSem(semesterid);
                    Facultyroom fr = new Facultyroom(allocationid, reservedHours, facultyid, roomid, semesterid, faculty, room, semester);
                    allocations.Add(fr);
                }
            }
            return allocations;
        }
        public void InsertFacultyRoom(Facultyroom fr)
        {
            string query = $"Insert into faculty_room_allocation (reserved_hours, faculty_id, room_id, semester_id) Values ({fr.reservedHours}, {fr.facultyid}, {fr.roomid}, {fr.semesterid})";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteFacultyRoom(int allocationid)
        {
            string query = $"Delete from faculty_room_allocation where allocation_id = {allocationid}";
            DatabaseHelper.Instance.Update(query);
        }
        public void UpdateFacultyRoom(Facultyroom fr)
        {
            string query = $"Update faculty_room_allocation set reserved_hours = {fr.reservedHours}, faculty_id = {fr.facultyid}, room_id = {fr.roomid}, semester_id = {fr.semesterid} where allocation_id = {fr.allocationid}";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteByFaculty(int facultyid)
        {
            string query = $"Delete from faculty_room_allocation where faculty_id = {facultyid}";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteByRoom(int roomid)
        {
            string query = $"Delete from faculty_room_allocation where room_id = {roomid}";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteBySemester(int semesterid)
        {
            string query = $"Delete from faculty_room_allocation where semester_id = {semesterid}";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
