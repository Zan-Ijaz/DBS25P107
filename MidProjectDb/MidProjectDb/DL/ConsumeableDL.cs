using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.BL;
using MidProjectDb.BL.MidProjectDb.BL;
using MidProjectDb.UI;

namespace MidProjectDb.DL
{
    public class ConsumeableDL
    {
        public DataTable GetDataTable()
        {
            string query = $"Select * from consumables";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            return dt;
        }
        public List<Consumable> getData()
        {
            List<Consumable> consumables = new List<Consumable>();
            string query = $"Select * from consumables";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int id = Convert.ToInt32(row["consumable_id"]);
                    string name = row["item_name"].ToString();
                    Consumable ca = new Consumable(id,name);
                    consumables.Add(ca);
                }
            }
            return consumables;
        }
        public void insertconsumables(Consumable ca)
        {
            string query = $"Insert into consumables(item_name) Values ('{ca.ItemName}')";
            DatabaseHelper.Instance.Update(query);
        }

        public void deleteconsumables(int id)
        {
            string query = $"DELETE FROM consumables WHERE consumable_id = {id}";
            DatabaseHelper.Instance.Update(query);
        }
        public void update(Consumable ca)
        {
            string query = $"Update consumables set item_name='{ca.ItemName}' where consumable_id='{ca.ConsumableId}'";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
