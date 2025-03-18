using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MidProjectDb.BL.MidProjectDb.BL;
using MidProjectDb.DL;

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
        static FacultyReqDL FacultyReqDLobj = new FacultyReqDL();
        public static bool validation(FacultyReq fr)
        {
            List<FacultyReq> reqs = FacultyReqDLobj.GetData();
            foreach(var req in reqs)
            {
                if (req.itemid == fr.itemid && fr.facultyid == req.facultyid&&req.quantity>0&&fr.statusid==req.statusid)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool validation(FacultyReq fr,int id)
        {
            List<FacultyReq> reqs = FacultyReqDLobj.GetData();
            foreach (var req in reqs)
            {
                if (req.itemid == fr.itemid && fr.facultyid == req.facultyid && id!=req.requestid && fr.statusid == req.statusid )
                {
                    return false;
                }
            }
            return true;
        }
        public static bool add(FacultyReq fr)
        {
            if (validation(fr) && fr.quantity > 0)
            {
                FacultyReqDLobj.InsertFacultyRequest(fr);
                return true;
            }
            return false;
        }
        public static bool update(FacultyReq fr)
        {
            if (validation(fr,fr.requestid) && fr.quantity > 0)
            {
                FacultyReqDLobj.UpdateFacultyRequest(fr);
                return true;
            }
            return false;
        }
        public static void delete(int id)
        {
            FacultyReqDLobj.DeleteFacultyRequest(id);
        }
        public static void deletebyfac(int id)
        {
            FacultyReqDLobj.DeleteByFaculty(id);
        }
        public static void deletebyitem(int id)
        {
            FacultyReqDLobj.DeleteByitem(id);
        }
        public static List<FacultyReq> GetData()
        {
            List<FacultyReq> reqs = FacultyReqDLobj.GetData();
            return reqs;
        }
        public static FacultyReq findReq(int id)
        {
            List<FacultyReq> reqs = GetData();
            foreach(var r in reqs)
            {
                if (id == r.requestid)
                {
                    return r;
                }
            }
            return null;
        }
    }
}
