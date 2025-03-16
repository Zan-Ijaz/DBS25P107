using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.DL;

namespace MidProjectDb.BL
{
    namespace MidProjectDb.BL
    {
        public class Consumable
        {
            public int ConsumableId { get; set; }
            public string ItemName { get; set; }
            public Consumable(int ConsumableId, string ItemName)
            {
                this.ConsumableId = ConsumableId;
                this.ItemName = ItemName;
            }
            public Consumable(string ItemName)
            {
                this.ItemName = ItemName;
            }
            public static ConsumeableDL consumeables = new ConsumeableDL();
            public static bool update(Consumable ca)
            {
                if(Utility.Utility.stringvalidation(ca.ItemName)&&duplication(ca.ItemName,ca.ConsumableId))
                {
                    consumeables.update(ca);
                    return true;
                }
                return false;
            }
            public static bool duplication(string title)
            {
                List<Consumable> cons = consumeables.getData();
                foreach(var c in cons)
                {
                    if (c.ItemName == title)
                    {
                        return false;
                    }
                }
                return true;
            }
            public static bool duplication(string title,int id)
            {
                List<Consumable> cons = consumeables.getData();
                foreach (var c in cons)
                {
                    if (c.ItemName == title&& c.ConsumableId!=id)
                    {
                        return false;
                    }
                }
                return true;
            }
            public static void delete(int id)
            {
                consumeables.deleteconsumables(id);
            }
            public static bool addConsumeable(Consumable ca)
            {
                if(Utility.Utility.stringvalidation(ca.ItemName) && duplication(ca.ItemName))
                {
                    consumeables.insertconsumables(ca);
                    return true;
                }
                return false;
            } 
            public static DataTable GetTable()
            {
                DataTable dt = consumeables.GetDataTable();
                return dt;
            }
            public static Consumable findconsumable(int id)
            {
                List<Consumable> cons = consumeables.getData();
                foreach(var c in cons)
                {
                    if (id == c.ConsumableId)
                    {
                        return c;
                    }
                }
                return null;
            }
        }
    }
}
