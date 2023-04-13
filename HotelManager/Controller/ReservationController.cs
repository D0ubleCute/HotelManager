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

        public static DataTable GetReservationByDate(DateTime fromDate, DateTime toDate)
        {
            return ReservationDAO.GetReservationByDate(fromDate, toDate);
        }

        public static bool InsertReservation(short num, short acco, DateTime checkIn, DateTime checkOutInit, string idCus, string idStaff)
        {
            return ReservationDAO.InsertReservation(num, acco, checkIn, checkOutInit, idCus, idStaff);
        }


        public static bool UpdateReservation(string idRes, short roomNum, short accomType,
                                           DateTime checkIn, DateTime checkOutInit, DateTime? checkoutReal,
                                           string idCus, string idStaff, decimal total, bool status, string info)
        {
            return ReservationDAO.UpdateReservation(idRes, roomNum, accomType, checkIn, checkOutInit, checkoutReal, idCus, idStaff, total, status, info);
        }
    }
}
