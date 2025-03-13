using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System.Xml.Linq;
using MidProjectDb.BL;
using MidProjectDb.UI;
namespace MidProjectDb.DL
{
    public class FacultyDL
    {
        public List<Faculty> getData()
        {
            List<Faculty> newfac = new List<Faculty>();
            string query = $"Select * from faculty";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            if(dt!=null){
                foreach (DataRow reader in dt.Rows)
                {
                    int facultyid = Convert.ToInt32(reader["faculty_id"]);
                    string name = reader["name"].ToString();
                    string email = reader["email"].ToString();
                    string contact = reader["contact"].ToString();
                    int designation_id = Convert.ToInt32(reader["designation_id"]);
                    string research_area = reader["research_area"].ToString();
                    int total_teaching_hours = Convert.ToInt32(reader["total_teaching_hours"]);
                    int user_id = reader["user_id"] == DBNull.Value ? -1 : Convert.ToInt32(reader["user_id"]);
                    UI.User user = UI.User.finduser(user_id);
                    Lookup lookup = Lookup.findlookup(designation_id);
                    Faculty faculty = new Faculty(facultyid, name, email, contact, research_area, total_teaching_hours, user_id, designation_id, user, lookup);
                    newfac.Add(faculty);
                }
            }
            return newfac;
        }
        public void Delete(int userId)
        {
            string deleteFacultyQuery = $"DELETE FROM faculty WHERE user_id = {userId}";
            DatabaseHelper.Instance.Update(deleteFacultyQuery);

        }
        public void insertfaculty(Faculty f)
        {
            string query=$"Insert into faculty (name, email, contact, designation_id, research_area, total_teaching_hours, user_id) Values ('{f.Name}','{f.Email}','{f.Contact}','{f.DesignationId}','{f.ResearchArea}','{f.TotalTeachingHours}','{f.UserId}')";
            DatabaseHelper.Instance.Update(query);
        }
        public void update(Faculty f)
        {
            string facultyquery = $"Update faculty set name='{f.Name}', email='{f.Email}', contact='{f.Contact}', designation_id='{f.DesignationId}', research_area='{f.ResearchArea}', total_teaching_hours='{f.TotalTeachingHours}' where user_id='{f.UserId}'";
            DatabaseHelper.Instance.Update(facultyquery);

        }
    }
}
