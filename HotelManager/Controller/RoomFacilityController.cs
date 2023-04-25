using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManager.DAO;

namespace HotelManager.Controller
{
    public class RoomFacilityController
    {
        public static List<RoomFacility> getRoomFacility(short roomNum)
        {
            return RoomFacilityDAO.getRoomFacility(roomNum);
        }

        public static string loadRoomFacility(short roomNum)
        {
            return RoomFacilityDAO.loadRoomFacility(roomNum);
        }

        public static bool InsertRoomFacility(string nameFacility, short roomNum)
        {
            return RoomFacilityDAO.InsertRoomFacility(roomNum, nameFacility);
        }
    }
}
