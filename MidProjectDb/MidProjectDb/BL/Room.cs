using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using MidProjectDb.BL;
using MidProjectDb.DL;
using Mysqlx.Crud;

namespace MidProjectDb.UI
{

    public class Room
    {
        public int roomid { get; set; }
        public string roomname { get; set; }
        public string roomtype{get;set;}
        public int capacity { get; set; }
        public Room(int roomid, string roomname, string roomtype, int capacity)
        {
            this.roomid = roomid;
            this.roomname = roomname;
            this.roomtype = roomtype;
            this.capacity = capacity;
        }
        public Room( string roomname, string roomtype, int capacity)
        {
            this.roomname = roomname;
            this.roomtype = roomtype;
            this.capacity = capacity;
        }
        static RoomDL rooms = new RoomDL();
        public static bool duplication(string name)
        {
            List<Room> roomList = rooms.GetData();
            foreach(var room in roomList)
            {
                if (room.roomname == name)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool duplication(string name,int id)
        {
            List<Room> roomList = rooms.GetData();
            foreach (var room in roomList)
            {
                if (room.roomname == name&&room.roomid!=id)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool validation(Room r)
        {
            if(Utility.Utility.stringvalidation(r.roomname)&&r.roomtype!=""&&r.capacity>0&& r.capacity < 1000)
            {
                return true;
            }
                return false;
        }
        public static bool update(Room r)
        {
            if (duplication(r.roomname, r.roomid) && validation(r))
            {
                rooms.UpdateRoom(r);
                return true;
            }
            return false;
        }
        public static bool add(Room r)
        {
            if (duplication(r.roomname) && validation(r))
            {
                rooms.InsertRoom(r);
                return true;
            }
            return false;
        }
        public static void Delete(int id)
        {
            Facultyroom.deletebyroom(id);
            CourseSechdule.deletebyroom(id);
            rooms.DeleteRoom(id);
        }
        public static DataTable GetTable()
        {
            DataTable dt = rooms.GetDataTable();
            return dt;
        }
        public static Room findroom(int id)
        {
            List<Room> roomList = rooms.GetData();
            foreach(var r in roomList)
            {
                if (r.roomid == id)
                {
                    return r;
                }
            }
            return null;
        }
        public static List<Room> getData()
        {
            List<Room> roomList = rooms.GetData();
            return roomList;
        }
    }
}
