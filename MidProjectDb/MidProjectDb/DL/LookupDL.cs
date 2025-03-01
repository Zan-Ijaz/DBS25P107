using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ReportingServices.ReportProcessing.OnDemandReportObjectModel;
using MidProjectDb.BL;
using MidProjectDb.UI;

namespace MidProjectDb.DL
{
    public class LookupDL
    {
        public static List<UI.Lookup> lookups = new List<UI.Lookup>();
        public static List<UI.Lookup> getData()
        {
            string query = $"Select * from lookup";
            try
            {
                DatabaseHelper.Instance.getConnection();
                var reader = DatabaseHelper.Instance.getData(query);
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["lookup_id"]);
                    string categoryid = reader["category"].ToString();
                    string Value = reader["value"].ToString();
                    UI.Lookup look = new UI.Lookup(id, categoryid, Value);
                    lookups.Add(look);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return lookups;
        }
    }
}
