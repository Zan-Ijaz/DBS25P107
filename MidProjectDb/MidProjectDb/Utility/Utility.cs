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
        public static bool intValidatioin(string number)
        {
            foreach (char c in number)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
