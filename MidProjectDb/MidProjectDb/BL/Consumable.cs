using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectDb.BL
{
    namespace MidProjectDb.BL
    {
        public class Consumable
        {
            public int ConsumableId { get; set; } 
            public string ItemName { get; set; }  
            public Consumable(int ConsumableId,string ItemName)
            {
                this.ConsumableId = ConsumableId;
                this.ItemName = ItemName;
            }
        }
    }
}
