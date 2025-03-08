using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidProjectDb.DL;

namespace MidProjectDb.UI
{
    public class User
    {
        public int userid { get; set; }
        public string username{ get; set; }
        public string email{ get; set; }
        public string password{ get; set; }
        public int roleId { get; set; }  
        public Lookup role { get; set; }
        public User (int userid, string username, string email, string password, int roleId, Lookup role)
        {
            this.userid = userid;
            this.username = username;
            this.email = email;
            this.password = password;
            this.roleId = roleId;
            this.role = role;
        }
        public User(int userid, string username, string email, int roleId, Lookup role)//For updating
        {
            this.userid = userid;
            this.username = username;
            this.email = email;
            this.roleId = roleId;
            this.role = role;
        }
        public User( string username, string email, string password, int roleId, Lookup role)//Using this one for adding user
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.roleId = roleId;
            this.role = role;
        }
        public static int findid(string username)
        {
            UserDL userdlobject=new UserDL();
            List<User> users = userdlobject.getData();
            int id = -1;
            foreach(var user in users)
            {
                if (username == user.username)
                {
                    id = user.userid;
                }
            }
            return id;
        }
        public static User finduser(int id)
        {
            UserDL userdlobject = new UserDL();
            List<User> users = userdlobject.getData();
            foreach (var user in users)
            {
                if (id == user.userid)
                {
                    return user;
                }
            }
            return null;
        }
        public static User finduser(string name)
        {
            UserDL userdlobject = new UserDL();
            List<User> users = userdlobject.getData();
            foreach (var user in users)
            {
                if (name == user.username)
                {
                    return user;
                }
            }
            return null;
        }
        public static bool emailduplication(string email)
        {
            UserDL userdlobject = new UserDL();
            List<User> users = userdlobject.getData();
            foreach (var user in users)
            {
                if (user.email.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool nameduplication(string name)
        {
            UserDL userdlobject = new UserDL();
            List<User> users = userdlobject.getData();
            foreach (var user in users)
            {
                if (user.username.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool emailduplication(string email,int id)
        {
            UserDL userdlobject = new UserDL();
            List<User> users = userdlobject.getData();
            foreach (var user in users)
            {
                if (user.email.Equals(email, StringComparison.OrdinalIgnoreCase)&&id!=user.userid)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool nameduplication(string name,int id)
        {
            UserDL userdlobject = new UserDL();
            List<User> users = userdlobject.getData();
            foreach (var user in users)
            {
                if (user.username.Equals(name, StringComparison.OrdinalIgnoreCase)&&id!=user.userid)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool emailvalidation(string email)
        {
            bool attherate = false;
            bool dot = false;
            foreach (char c in email)
            {
                if (c == '@') attherate = true;
                if (c == '.') dot = true;

            }
            if (dot && attherate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void update(User u)
        {
            UserDL userdlobject = new UserDL();
            userdlobject.update(u);
        }
        public static void delete(int id)
        {   
            UserDL userdlobject = new UserDL();
            userdlobject.Delete(id);
        }
        public static DataTable loadSignupGRID()
        {   
            UserDL userdlobject = new UserDL();
            DataTable dt = userdlobject.loadSignupgrid();
            return dt;
        }
        public static void insert(User u)
        {   
            UserDL userdlobject = new UserDL();
            userdlobject.insertUser(u);
        }
        public static bool ValidateUser(User u, out string errorMessage)
        {
            if (!Utility.Utility.stringvalidation(u.username) || !User.nameduplication(u.username, u.userid))
            {
                errorMessage = "Invalid string added as username or username already exists.";
                return false;
            }
            if (!Utility.Utility.stringvalidation(u.email) || !User.emailvalidation(u.email) || !User.nameduplication(u.email, u.userid))
            {
                errorMessage = "Invalid email added or email already exists.";
                return false;
            }

            errorMessage = "";
            return true;
        }
        public static DataRow signin(string username, string password)
        {
            if (Utility.Utility.stringvalidation(username) && Utility.Utility.stringvalidation(password))
            {
                UserDL userDLobj = new UserDL();
                DataRow dr = userDLobj.signin(username, password);
                return dr;
            }
            else
            {
                return null;
            }
        }
        public static int hod(int id)
        {
            UserDL userDLobj = new UserDL();
            int count = userDLobj.hodCount(id);
            return count;
        }
        public static DataRow forgotpassword(string username,string email)
        {
            if (Utility.Utility.stringvalidation(username) && Utility.Utility.stringvalidation(email))
            {
                UserDL userDLobj = new UserDL();
                DataRow dr=userDLobj.forgot(username, email);
                return dr;
            }
            else
            {
                return null;
            }
        }
        public static bool changepassword(DataRow dr ,string password)
        {
            if(password.Length>=8&&Utility.Utility.stringvalidation(password))
            {
                int id = Convert.ToInt32(dr["user_id"]);
                UserDL userDLobj = new UserDL();
                userDLobj.setPassword(id, password);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
