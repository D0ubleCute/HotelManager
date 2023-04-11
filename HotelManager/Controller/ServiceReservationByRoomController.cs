using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HotelManager.DAO;

namespace HotelManager.Controller
{
    public class ServiceReservationByRoomController
    {
        public static List<RoomExtraByRoom> GetRoomService()
        {
            return ServiceReservationByRoomDAO.GetRoomService();
        }

        public static DataTable GetRoomServiceList()
        {
            return ServiceReservationByRoomDAO.GetRoomServiceList();
        }

        public static DataTable GetRoomServiceListByReservation(string idRes)
        {
            return ServiceReservationByRoomDAO.GetRoomServiceListByReservation(idRes);
        }
    }
}
