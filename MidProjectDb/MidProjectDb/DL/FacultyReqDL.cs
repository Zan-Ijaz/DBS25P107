using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.BL.MidProjectDb.BL;
using MidProjectDb.BL;
using MidProjectDb.UI;

namespace MidProjectDb.DL
{
    public class FacultyReqDL
    {
        public DataTable GetDataTable()
        {
            string query = "SELECT * FROM faculty_requests";
            return DatabaseHelper.Instance.GetData(query);
        }
        public List<FacultyReq> GetData()
        {
            List<FacultyReq> requests = new List<FacultyReq>();
            string query = "SELECT * FROM faculty_requests";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int request_id = Convert.ToInt32(row["request_id"]);
                    int faculty_id = Convert.ToInt32(row["faculty_id"]);
                    int status_id = Convert.ToInt32(row["status_id"]);
                    int item_id = Convert.ToInt32(row["item_id"]);
                    int quantity = Convert.ToInt32(row["quantity"]);
                    DateTime requestDate = Convert.ToDateTime(row["request_date"]);
                    Faculty faculty = Faculty.findFaculty(faculty_id);
                    Consumable item = Consumable.findconsumable(item_id);
                    Lookup status = Lookup.findlookup(status_id);
                    FacultyReq req = new FacultyReq(request_id, faculty_id, status_id, item_id, quantity, requestDate, faculty, item, status);
                    requests.Add(req);
                }
            }
            return requests;
        }

        public void InsertFacultyRequest(FacultyReq req)
        {
            string query = $"INSERT INTO faculty_requests (faculty_id, status_id, item_id, quantity, request_date) VALUES ({req.facultyid}, {req.statusid}, {req.itemid}, {req.quantity}, '{req.request_date:yyyy-MM-dd HH:mm:ss}')";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteFacultyRequest(int id)
        {
            string query = $"DELETE FROM faculty_requests where request_id = {id}";
            DatabaseHelper.Instance.Update(query);
        }

        public void UpdateFacultyRequest(FacultyReq req)
        {
            string query = $"UPDATE faculty_requests SET faculty_id = {req.facultyid}, status_id = {req.statusid}, item_id = {req.itemid}, quantity = {req.quantity}, request_date = '{req.request_date:yyyy-MM-dd HH:mm:ss}' where request_id = {req.requestid}";
            DatabaseHelper.Instance.Update(query);
        }

        public void DeleteByFaculty(int faculty_id)
        {
            string query = $"DELETE FROM faculty_requests where faculty_id = {faculty_id}";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteByitem(int faculty_id)
        {
            string query = $"DELETE FROM faculty_requests where item_id = {faculty_id}";
            DatabaseHelper.Instance.Update(query);
        }

    }
}
