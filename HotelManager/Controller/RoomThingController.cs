using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManager.DAO;

namespace HotelManager.Controller
{
    public class RoomThingController
    {
        public static List<RoomThing> GetRoomThings()
        {

            return RoomThingDAO.GetRoomThings();
        }

        public static List<RoomThing> GetRoomThingsByRoomNum(short roomNum)
        {

            return RoomThingDAO.GetRoomThingsByRoomNum(roomNum);
        }

        public static DataTable GetRoomThingsTable()
        {
            return RoomThingDAO.GetRoomThingsTable();
        }


        public static DataTable GetRoomThingsTableByRoomNum(short roomNum)
        {
            return RoomThingDAO.GetRoomThingsTableByRoomNum(roomNum);
        }
    }
}
