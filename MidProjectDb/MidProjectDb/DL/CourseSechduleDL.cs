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
    public class CourseSechduleDL
    {
        
        public List<CourseSechdule> GetData()
        {
            List<CourseSechdule> schedules = new List<CourseSechdule>();
            string query = "Select * from faculty_course_schedule";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
    
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int schedule_id = Convert.ToInt32(row["schedule_id"]);
                    int faculty_course_id = Convert.ToInt32(row["faculty_course_id"]);
                    int room_id = Convert.ToInt32(row["room_id"]);
                    string day = row["day_of_week"].ToString();
                    DateTime starttime = Convert.ToDateTime(row["start_time"]);
                    DateTime endtime = Convert.ToDateTime(row["end_time"]);
                    Facultycourse fc = Facultycourse.findfacultycourse(faculty_course_id);
                    Room room = Room.findroom(room_id);
                    CourseSechdule cs = new CourseSechdule(schedule_id, faculty_course_id, room_id, fc, room, day, starttime, endtime);
                    schedules.Add(cs);
                }
            }
            return schedules;
        }
        public void InsertCourseSechdule(CourseSechdule cs)
        {
            string query = $"Insert into faculty_course_schedule (faculty_course_id, room_id, day_of_week, start_time, end_time) Values ({cs.facultycourseid}, {cs.roomid}, '{cs.day}', '{cs.starttime:HH:mm:ss}', '{cs.Endtime:HH:mm:ss}')";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteCourseSechdule(int schedule_id)
        {
            string query = $"Delete from faculty_course_schedule where schedule_id = {schedule_id}";
            DatabaseHelper.Instance.Update(query);
        }
        public void UpdateCourseSechdule(CourseSechdule cs)
        {
            string query = $"Update faculty_course_schedule SET faculty_course_id = {cs.facultycourseid}, room_id = {cs.roomid}, day_of_week = '{cs.day}', start_time = '{cs.starttime:HH:mm:ss}', end_time = '{cs.Endtime:HH:mm:ss}' where schedule_id = {cs.Sechduleid}";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeletebyFacultycourse(int id)
        {
            string query = $"Delete from faculty_course_schedule where  faculty_course_id={id}";
            DatabaseHelper.Instance.Update(query);
        }
        public void Deletebyroom(int id)
        {
            string query = $"Delete from faculty_course_schedule where  room_id={id}";
            DatabaseHelper.Instance.Update(query);
        }

    }
}
