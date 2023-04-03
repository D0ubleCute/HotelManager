using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManager.DAO;

namespace HotelManager.Controller
{
    public class ReservationController
    {
        public static List<Reservation> GetReservation()
        {
            return ReservationDAO.GetReservation();
        }

        public static DataTable GetReservationList()
        {
            return ReservationDAO.GetReservationList();
        }

        public static decimal reservationPayCheck(string customerID, string staffID, int roomNum, string reservationID, DateTime fromDate)
        {
            return ReservationDAO.reservationPayCheck(customerID, staffID, roomNum, reservationID, fromDate);
        }
    }
}
