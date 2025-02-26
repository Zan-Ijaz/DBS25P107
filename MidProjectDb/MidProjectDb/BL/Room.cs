using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidProjectDb.UI
{
    public enum roomType { Classroom,Lab }

    public class Room
    {
        public int roomid { get; set; }
        public int roomname { get; set; }
        public roomType roomtype{get;set;}
        public int capacity { get; set; }
    }
}
