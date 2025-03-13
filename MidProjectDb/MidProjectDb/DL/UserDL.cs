using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using MidProjectDb.BL;
using MidProjectDb.UI;
namespace MidProjectDb.DL
{
    public class UserDL
    {
        public List<UI.User> getData()
        {
            List<UI.User> newusers = new List<UI.User>();
            string query = $"Select * From users";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            if (dt != null)
            {
                foreach (DataRow reader in dt.Rows)
                {
                    int userid = Convert.ToInt32(reader["user_id"]);
                    int roleid = Convert.ToInt32(reader["role_id"]);
                    string username = (reader["username"].ToString());
                    string Password = (reader["password_hash"].ToString());
                    string email = reader["email"].ToString();
                    Lookup lookup = Lookup.findlookup(roleid);
                    UI.User u = new UI.User(userid, username, email, Password, roleid, lookup);
                    newusers.Add(u);
                }
            }
            return newusers;
        }
        public void insertUser(UI.User u)
        {
            string userquery = $"Insert into users (username,email,password_hash,role_id) Values('{u.username}','{u.email}',SHA2('{u.password}',256),'{u.roleId}')";
            //Assigning 2 bcz newly added member is faculty member
            DatabaseHelper.Instance.Update(userquery);

        }
        public int hodCount(int userid)
        {
            int count = 0;
            string query = $"Select count(*) as counter from users where role_id=3 and user_id <> '{userid}';";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            foreach (DataRow reader in dt.Rows)
            {
                count = Convert.ToInt32(reader["Counter"]);
            }
            return count;
        }
        public void update(UI.User u)
        {
            string userquery = $"Update users set username='{u.username}', email='{u.email}', role_id='{u.roleId}' where user_id='{u.userid}' ";
            DatabaseHelper.Instance.Update(userquery);
        }
        public void Delete(int userId)
        {
            string deleteFacultyQuery = $"DELETE FROM users WHERE user_id = {userId}";
            DatabaseHelper.Instance.Update(deleteFacultyQuery);
        }
        public DataTable loadSignupgrid()
        {
            string query = $"SELECT f.name as Name,f.email as Email ,f.contact as Contact ,d.value as Designation,f.research_area as ResearchArea,f.total_teaching_hours as TotalTeachingHours,r.value as Role,f.user_id as UserID from faculty f inner join lookup d on f.designation_id=d.lookup_id inner join users as u on f.user_id=u.user_id inner join lookup r on u.role_id=r.lookup_id order by role,Name";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            return dt;
        }
        public DataRow signin(string username,string password)
        {
            string query = $"Select* From users where username='{username}' And password_hash=SHA2('{password}',256)";
            DataTable dt=DatabaseHelper.Instance.GetData(query);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
        public DataRow forgot(string username, string email)
        {
            string query = $"Select* From users where username='{username}' And email='{email}'";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
        public void setPassword(int id,string password)
        {
            string query = $"Update users set password_hash=SHA2('{password}',256) where user_id='{id}'";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
