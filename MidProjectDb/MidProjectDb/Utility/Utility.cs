using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectDb.Utility
{
    public class Utility
    {
        public static bool stringvalidation(string str)
        {
            foreach(char c in str)
            {
                if (c == '\t' || c == '\n' || c == '"' || c == '\'' || str == "")
                {
                    return false;
                }
            }
            return true;
        }
    }
}
