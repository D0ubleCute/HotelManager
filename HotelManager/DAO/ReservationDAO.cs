using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManager.Controller;

namespace HotelManager.DAO
{
    public class ReservationDAO
    {
        public static decimal reservationPayCheck(string customerID, string staffID, int roomNum, string reservationID, DateTime fromDate)
        {
            decimal servicePayCheckSum = 0;
            decimal reservationPayCheckSum = 0;
            Customer customer = CustomerController.GetCustomerById(customerID);
            Staff staff = StaffController.GetStaffById(staffID);

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from res in db.Reservations
                            where res.idReservation.Equals(reservationID) &&
                            res.idCustomer.Equals(customerID) && res.roomNum == roomNum && res.checkinDate == fromDate
                            select res;

                foreach (var item in query)
                {
                    if (item.paymentStatus == true)
                    {
                        var query2 = db.USP_GetRoomExtraPriceByReservation(item.idReservation); 

                        foreach (var item2 in query2)
                        {
                            servicePayCheckSum += item2.priceService;
                        }
                        reservationPayCheckSum += item.totalPrice + servicePayCheckSum;
                        Console.WriteLine(item.totalPrice);
                        Console.WriteLine(reservationPayCheckSum);
                    }
                }
            }

            return reservationPayCheckSum;
        }

        public static List<Reservation> GetReservation()
        {
            List<Reservation> reservationList = new List<Reservation>();

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from cus in db.Reservations
                            select cus;

                foreach (var item in query)
                {
                    reservationList.Add(item);
                }
            }

            return reservationList;
        }

        public static DataTable GetReservationList()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã đặt phòng", typeof(string));
            dt.Columns.Add("Số phòng", typeof(int));
            dt.Columns.Add("Loại hình", typeof(string));
            dt.Columns.Add("Check-in", typeof(string));
            dt.Columns.Add("Check-out", typeof(string));
            dt.Columns.Add("Khách hàng", typeof(string));
            dt.Columns.Add("Nhân viên", typeof(string));
            dt.Columns.Add("Trạng thái", typeof(string));
            dt.Columns.Add("Tổng tiền", typeof(decimal));

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from res in db.Reservations
                            join cus in db.Customers on res.idCustomer equals cus.id
                            join staff in db.Staffs on res.idStaff equals staff.id
                            select new
                            {
                                idReservation = res.idReservation,
                                roomNum = res.roomNum,
                                accomodationType = res.accomodationType,
                                checkinDate = res.checkinDate,
                                checkoutDate = res.checkoutDate,
                                customerName = cus.fullName,
                                staffName = staff.fullName,
                                paymentStatus = res.paymentStatus,
                                totalPrice = reservationPayCheck(res.idCustomer, res.idStaff, res.roomNum, res.idReservation, res.checkinDate)
                                // other assignments
                            };

            foreach (var item in query)
                {
                    if (item.accomodationType == 1)
                    {
                        dt.Rows.Add(item.idReservation, item.roomNum, "GIỜ",
                        item.checkinDate.ToString("dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture),
                        item.checkoutDate,
                        item.customerName, item.staffName, item.paymentStatus, item.totalPrice);
                    }
                    else if (item.accomodationType == 2)
                    {
                        dt.Rows.Add(item.idReservation, item.roomNum, "ĐÊM",
                        item.checkinDate.ToString("dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture),
                        item.checkoutDate,
                        item.customerName, item.staffName, item.paymentStatus, item.totalPrice);
                    }
                    else
                    {
                        dt.Rows.Add(item.idReservation, item.roomNum, "NGÀY",
                        item.checkinDate.ToString("dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture),
                        item.checkoutDate,
                        item.customerName, item.staffName, item.paymentStatus, item.totalPrice);
                    }
                }
                return dt;
            }
        }       
    }
}
