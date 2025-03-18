using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using MidProjectDb.UI;

namespace MidProjectDb.BL
{
    public class LoggedInUser//Uusing this class to keep track of signed in user
    {
        public static DataRow LoggedUser { get; private set; }
        public static void SetLoggedInUser(DataRow userRow)
        {
            LoggedUser = userRow;
        }
        public static void ClearSession()
        {
            LoggedUser = null;
        }
    }
}
