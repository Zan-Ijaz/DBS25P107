using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MidProjectDb.BL;
using MidProjectDb.UI;
namespace MidProjectDb.DL
{
    public class UserDL
    {
        public static List<User> users = new List<User>();
        public static List<User> getData()
        {
            string query = $"Select * From users";
             
            var reader = DatabaseHelper.Instance.getData(query);
            while (reader.Read())
            {
                int userid = Convert.ToInt32(reader["user_id"]);
                int roleid = Convert.ToInt32(reader["role_id"]);
                string username = (reader["username"].ToString());
                string Password = (reader["password_hash"].ToString());
                string email = reader["email"].ToString();
                Lookup lookup = Lookup.findlookup(roleid);
                User u = new User(userid, username, Password, email, roleid, lookup);
                users.Add(u);
            }
            return users;
        }
        public static void insertUser(User u)
        {
            string userquery = $"Insert into users (username,email,password_hash,role_id) Values('{u.username}','{u.email}','{u.password}','{2}')";
            //Assigning 2 bcz newly added member is faculty member
            DatabaseHelper.Instance.Update(userquery);

        } 
    }
}
