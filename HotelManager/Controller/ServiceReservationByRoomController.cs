using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HotelManager.DAO;
using System.Windows.Forms;

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


        public static decimal GetServiceTotalPrice(DataGridView dtgv)
        {
            return ServiceReservationByRoomDAO.GetServiceTotalPrice(dtgv);
        }

        public static bool InsertServiceInfo(string idSer, short roomNum, short qty, string idRes)
        {
            return ServiceReservationByRoomDAO.InsertServiceInfo(idSer, roomNum, qty, idRes);
        }

    }
}
