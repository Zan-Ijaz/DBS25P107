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
                    int requestId = Convert.ToInt32(row["requestid"]);
                    int facultyId = Convert.ToInt32(row["facultyid"]);
                    int statusId = Convert.ToInt32(row["statusid"]);
                    int itemId = Convert.ToInt32(row["itemid"]);
                    int quantity = Convert.ToInt32(row["quantity"]);
                    DateTime requestDate = Convert.ToDateTime(row["request_date"]);
                    Faculty faculty = Faculty.findFaculty(facultyId);
                    Consumable item = Consumable.findconsumable(itemId);
                    Lookup status = Lookup.findlookup(statusId);
                    FacultyReq req = new FacultyReq(requestId, facultyId, statusId, itemId, quantity, requestDate, faculty, item, status);
                    requests.Add(req);
                }
            }
            return requests;
        }

        public void InsertFacultyRequest(FacultyReq req)
        {
            string query = $"INSERT INTO faculty_requests (facultyid, statusid, itemid, quantity, request_date) VALUES ({req.facultyid}, {req.statusid}, {req.itemid}, {req.quantity}, '{req.request_date:yyyy-MM-dd HH:mm:ss}')";
            DatabaseHelper.Instance.Update(query);
        }
        public void DeleteFacultyRequest(int id)
        {
            string query = $"DELETE FROM faculty_requests WHERE requestid = {id}";
            DatabaseHelper.Instance.Update(query);
        }

        public void UpdateFacultyRequest(FacultyReq req)
        {
            string query = $"UPDATE faculty_requests SET facultyid = {req.facultyid}, statusid = {req.statusid}, itemid = {req.itemid}, quantity = {req.quantity}, request_date = '{req.request_date:yyyy-MM-dd HH:mm:ss}' WHERE requestid = {req.requestid}";
            DatabaseHelper.Instance.Update(query);
        }

        public void DeleteByFaculty(int facultyId)
        {
            string query = $"DELETE FROM faculty_requests WHERE facultyid = {facultyId}";
            DatabaseHelper.Instance.Update(query);
        }

        
        public DataTable LoadDataGrid()
        {
            string query = "SELECT fr.request_id, f.name AS Faculty, fr.quantity AS Quantity, c.item_name AS Item, l.value AS Status, fr.request_date AS RequestDate, fr.faculty_id, fr.status_id, fr.item_id FROM faculty_requests fr Natural JOIN faculty f Natural JOIN consumables c Natural JOIN lookup l \r\n";

            return DatabaseHelper.Instance.GetData(query);
        }
    }
}
