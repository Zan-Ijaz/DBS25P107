using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.BL;
using MidProjectDb.UI;
namespace MidProjectDb.DL
{
    public class FacultyDL
    {
        public static List<Faculty> facultymembers = new List<Faculty>();
        public static List<Faculty> getData()
        {
            string query = $"Select * from faculty";
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int facultyid = Convert.ToInt32(reader["faculty_id"]);
                string name = reader["name"].ToString();
                string email = reader["email"].ToString();
                string contact = reader["contact"].ToString();
                int designation_id = Convert.ToInt32(reader["designation_id"]);
                string research_area = reader["research_area"].ToString();
                int total_teaching_hours = Convert.ToInt32(reader["total_teaching_hours"]);
                int user_id = Convert.ToInt32(reader["user_id"]);
                User user = User.finduser(user_id);
                Lookup lookup = Lookup.findlookup(designation_id);
                Faculty faculty = new Faculty(facultyid, name, email, contact, research_area, total_teaching_hours,user_id,designation_id,user,lookup);
                facultymembers.Add(faculty);
            }
            return facultymembers;

        }
        public static void insertfaculty(Faculty f)
        {
            string query=$"Insert into faculty (name, email, contact, designation_id, research_area, total_teaching_hours, user_id) Values ('{f.Name}','{f.Email}','{f.Contact}','{f.DesignationId}','{f.ResearchArea}','{f.TotalTeachingHours}','{f.UserId}')";
            DatabaseHelper.Instance.Update(query);

        }
    }
}
