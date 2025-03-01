using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidProjectDb.DL;

namespace MidProjectDb.UI
{
    public class Lookup
    {
        public int lookupid { get; set; }
        public string categoryid { get; set; }
        public string value { get; set; }
        public Lookup(int lookupid, string categoryid, string value)
        {
            this.lookupid = lookupid;
            this.categoryid = categoryid;
            this.value = value;
        }
        public static Lookup findlookup(int id)
        {
            List<Lookup> lookups = LookupDL.getData();
            Lookup newlook;
            foreach (var looks in lookups)
            {
                if (id== looks.lookupid)
                {
                    newlook = new Lookup(looks.lookupid, looks.categoryid, looks.value);
                    return newlook;
                }
                
            }
            return null;
            
            
            
        }
    }
}
