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

        public static DataTable GetProcessingReservation()
        {
            return ReservationDAO.GetProcessingReservation();   
        }


        public static DataTable GetReservationByDate(DateTime fromDate, DateTime toDate)
        {
            return ReservationDAO.GetReservationByDate(fromDate, toDate);
        }

        public static DataTable GetReservationByCustomerID(string customerID)
        {
            return ReservationDAO.GetReservationByCustomerID(customerID);
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

        public static bool CloseProcessingReservation(string idRes, short roomNum, short accomType,
                                           DateTime checkIn, DateTime checkOutInit, DateTime? checkoutReal, decimal totalPrice, string info)
        {
            return ReservationDAO.CloseProcessingReservation(idRes, roomNum, accomType, checkIn, checkOutInit, checkoutReal, totalPrice, info);
        }

        public static Reservation FindProcessingReservationByRoomNum(short roomNum)
        {
            return ReservationDAO.FindProcessingReservationByRoomNum(roomNum);
        }

        public static Reservation GetReservationById(string idReservation)
        {
            return ReservationDAO.GetReservationById(idReservation);
        }

        public static bool CloseProcessingReservationAndChangeRoom(string idRes, short roomNum, short accomType,
                                           DateTime checkIn, DateTime checkOutInit, DateTime? checkoutReal, decimal totalPrice, string info,
                                           short newRoomNum, short newAccoType, DateTime newCheckIn, DateTime newCheckOutInit, string idStaff, string idCus)
        {
            return ReservationDAO.CloseProcessingReservationAndChangeRoom(idRes, roomNum, accomType, checkIn, checkOutInit, checkoutReal, totalPrice, info, newRoomNum, newAccoType, newCheckIn, newCheckOutInit,idCus, idStaff); ;
        }
    }
}
