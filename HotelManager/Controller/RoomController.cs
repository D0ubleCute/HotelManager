using HotelManager.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Controller
{
    public class RoomController
    {
        public static List<Room> GetRoomList()
        {
            List<Room> rooms = RoomDAO.LoadRoomList();

            return rooms;
        }
    }
}
