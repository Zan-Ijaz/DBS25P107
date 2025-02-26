using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
