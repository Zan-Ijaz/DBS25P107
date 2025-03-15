using System;
using System.Collections.Generic;
using System.Data;
using MidProjectDb.BL;
using MidProjectDb.UI;

namespace MidProjectDb.DL
{
    public class RoomDL
    {
        public DataTable GetDataTable()
        {
            string query = "Select * FROM rooms";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            return dt;
        }

        public List<Room> GetData()
        {
            List<Room> rooms = new List<Room>();
            string query = "Select * FROM rooms";
            DataTable dt = DatabaseHelper.Instance.GetData(query);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int id = Convert.ToInt32(row["room_id"]);
                    string name = row["room_name"].ToString();
                    string type = row["room_type"].ToString();
                    int capacity = Convert.ToInt32(row["capacity"]);
                    Room room = new Room(id, name, type, capacity);
                    rooms.Add(room);
                }
            }
            return rooms;
        }

        public void InsertRoom(Room room)
        {
            string query = $"Insert Into rooms (room_name, room_type, capacity) Values ('{room.roomname}', '{room.roomtype}', {room.capacity})";
            DatabaseHelper.Instance.Update(query);
        }

        public void DeleteRoom(int id)
        {
            string query = $"Delete from rooms where room_id = {id}";
            DatabaseHelper.Instance.Update(query);
        }

        public void UpdateRoom(Room room)
        {
            string query = $"Update rooms set room_name = '{room.roomname}', room_type = '{room.roomtype}', capacity = {room.capacity} where room_id = {room.roomid}";
            DatabaseHelper.Instance.Update(query);
        }
    }
}
