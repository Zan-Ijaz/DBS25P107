using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.BL;
using MidProjectDb.BL.MidProjectDb.BL;

namespace MidProjectDb.UI
{
    public class FacultyReq
    {
        public int requestid { get; set; }
        public int facultyid { get; set; }
        public int statusid { get; set; }
        public int itemid { get; set; }
        public int quantity { get; set; }
        public DateTime request_date { get; set; }
        public Faculty facultymember { get; set; }
        public Consumable item { get; set; }
        public Lookup status { get; set; }
        public FacultyReq(int requestid, int facultyid, int statusid, int itemid, int quantity, DateTime request_date, Faculty facultymember, Consumable item, Lookup status)
        {
            this.requestid = requestid;
            this.facultyid = facultyid;
            this.statusid = statusid;
            this.itemid = itemid;
            this.quantity = quantity;
            this.request_date = request_date;
            this.facultymember = facultymember;
            this.item = item;
            this.status = status;
        }
        public FacultyReq( int facultyid, int statusid, int itemid, int quantity, DateTime request_date, Faculty facultymember, Consumable item, Lookup status)
        {
            this.facultyid = facultyid;
            this.statusid = statusid;
            this.itemid = itemid;
            this.quantity = quantity;
            this.request_date = request_date;
            this.facultymember = facultymember;
            this.item = item;
            this.status = status;
        }
    }
}
