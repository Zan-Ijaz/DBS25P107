using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.BL.MidProjectDb.BL;

namespace MidProjectDb.UI
{
    public class FacultyRequestid
    {
        public int requestid { get; set; }
        public int? facultyid { get; set; }
        public int? statusid { get; set; }
        public int? itemid { get; set; }
        public int quantity { get; set; }
        public DateTime request_date { get; set; }

        public Faculty facultymember{ get; set; }
        public Consumable item { get; set; }
        public Lookup status { get; set; }
    }
}
