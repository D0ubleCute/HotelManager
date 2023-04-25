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
                            servicePayCheckSum += (item2.priceService*item2.serviceQty);
                        }
                        reservationPayCheckSum += item.totalPrice + servicePayCheckSum;
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
            dt.Columns.Add("Ngày Check-in", typeof(string));
            dt.Columns.Add("Ngày Check-out dự tính", typeof(string));
            dt.Columns.Add("Ngày Check-out thực tế", typeof(string));
            dt.Columns.Add("Tên khách hàng", typeof(string));
            dt.Columns.Add("SĐT khách hàng", typeof(string));
            dt.Columns.Add("Nhân viên", typeof(string));
            dt.Columns.Add("Trạng thái", typeof(string));
            dt.Columns.Add("Tổng tiền", typeof(decimal));

            using (HotelDataContext db = new HotelDataContext())
            {
                CultureInfo culture = new CultureInfo("vi-VN");

                var query = from res in db.Reservations
                            join cus in db.Customers on res.idCustomer equals cus.id
                            join staff in db.Staffs on res.idStaff equals staff.id
                            orderby res.checkinDate ascending
                            select new
                            {
                                idReservation = res.idReservation,
                                roomNum = res.roomNum,
                                accomodationType = res.accomodationType,
                                checkinDate = res.checkinDate,
                                checkoutDateInit = res.checkoutDate,
                                checkoutDateREAL = res.checkoutDateREAL,
                                customerName = cus.fullName,
                                customerPhone = cus.phone,
                                staffName = staff.fullName,
                                paymentStatus = res.paymentStatus,
                                totalPrice = reservationPayCheck(res.idCustomer, res.idStaff, res.roomNum, res.idReservation, res.checkinDate)
                                // other assignments
                            };

                foreach (var item in query)
                {
                    switch (item.accomodationType)
                    {
                        case 1:
                            if (item.paymentStatus == true)
                            {
                                dt.Rows.Add(item.idReservation, item.roomNum, "GIỜ",
                                item.checkinDate.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                "NaN",
                                Convert.ToDateTime(item.checkoutDateREAL).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                item.customerName, item.customerPhone, item.staffName, "Đã thanh toán", item.totalPrice);
                            }
                            else
                            {
                                dt.Rows.Add(item.idReservation, item.roomNum, "GIỜ",
                                item.checkinDate.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                "NaN", "NaN",
                                item.customerName, item.customerPhone, item.staffName, "Đang sử dụng", item.totalPrice);
                            }
                            break;

                        case 2:
                            if (item.paymentStatus == true)
                            {
                                dt.Rows.Add(item.idReservation, item.roomNum, "ĐÊM",
                                item.checkinDate.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateInit).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateREAL).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                item.customerName, item.customerPhone, item.staffName, "Đã thanh toán", item.totalPrice);
                            }
                            else
                            {
                                dt.Rows.Add(item.idReservation, item.roomNum, "ĐÊM",
                                Convert.ToDateTime(item.checkinDate).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateInit).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                "NaN",
                                item.customerName, item.customerPhone, item.staffName, "Đang sử dụng", item.totalPrice);
                            }
                            break;

                        case 3:
                            if (item.paymentStatus == true)
                            {
                                dt.Rows.Add(item.idReservation, item.roomNum, "NGÀY",
                                item.checkinDate.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateInit).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateREAL).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                item.customerName, item.customerPhone, item.staffName, "Đã thanh toán", item.totalPrice);
                            }
                            else
                            {
                                dt.Rows.Add(item.idReservation, item.roomNum, "NGÀY",
                                Convert.ToDateTime(item.checkinDate).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateInit).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                "NaN",
                                item.customerName, item.customerPhone, item.staffName, "Đang sử dụng", item.totalPrice);
                            }
                            break;

                    }
                }
                return dt;
            }
        }

        public static DataTable GetProcessingReservation()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã đặt phòng", typeof(string));
            dt.Columns.Add("Số phòng", typeof(int));
            dt.Columns.Add("Loại hình", typeof(string));
            dt.Columns.Add("Ngày Check-in", typeof(string));
            dt.Columns.Add("Ngày Check-out dự tính", typeof(string));
            dt.Columns.Add("Ngày Check-out thực tế", typeof(string));
            dt.Columns.Add("Tên khách hàng", typeof(string));
            dt.Columns.Add("SĐT khách hàng", typeof(string));
            dt.Columns.Add("Nhân viên", typeof(string));
            dt.Columns.Add("Trạng thái", typeof(string));
            dt.Columns.Add("Tổng tiền", typeof(decimal));

            using (HotelDataContext db = new HotelDataContext())
            {
                CultureInfo culture = new CultureInfo("vi-VN");

                var query = from res in db.Reservations
                            where res.paymentStatus == false
                            join cus in db.Customers on res.idCustomer equals cus.id
                            join staff in db.Staffs on res.idStaff equals staff.id
                            orderby res.checkinDate ascending
                            select new
                            {
                                idReservation = res.idReservation,
                                roomNum = res.roomNum,
                                accomodationType = res.accomodationType,
                                checkinDate = res.checkinDate,
                                checkoutDateInit = res.checkoutDate,
                                checkoutDateREAL = res.checkoutDateREAL,
                                customerName = cus.fullName,
                                customerPhone = cus.phone,
                                staffName = staff.fullName,
                                paymentStatus = res.paymentStatus,
                                totalPrice = reservationPayCheck(res.idCustomer, res.idStaff, res.roomNum, res.idReservation, res.checkinDate)
                            };

                foreach (var item in query)
                {
                    switch (item.accomodationType)
                    {
                        case 1:
                            dt.Rows.Add(item.idReservation, item.roomNum, "GIỜ",
                                item.checkinDate.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                "NaN", "NaN",
                                item.customerName, item.customerPhone, item.staffName, "Đang sử dụng", item.totalPrice);
                            break;

                        case 2:
                            dt.Rows.Add(item.idReservation, item.roomNum, "ĐÊM",
                                Convert.ToDateTime(item.checkinDate).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateInit).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                "NaN",
                                item.customerName, item.customerPhone, item.staffName, "Đang sử dụng", item.totalPrice);
                            break;

                        case 3:
                            dt.Rows.Add(item.idReservation, item.roomNum, "NGÀY",
                                 Convert.ToDateTime(item.checkinDate).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                 Convert.ToDateTime(item.checkoutDateInit).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                 "NaN",
                                 item.customerName, item.customerPhone, item.staffName, "Đang sử dụng", item.totalPrice);
                            break;

                    }
                }
                return dt;
            }
        }

        public static Reservation GetReservationById(string idRes)
        {
            List<Reservation> reservationList = GetReservation();

            foreach (var item in reservationList)
            {
                if (item.idReservation.Equals(idRes))
                {
                    return item;
                }
            }
            return null;
        }

        public static DataTable GetReservationByDate(DateTime fromDate, DateTime toDate)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã đặt phòng", typeof(string));
            dt.Columns.Add("Số phòng", typeof(int));
            dt.Columns.Add("Loại hình", typeof(string));
            dt.Columns.Add("Ngày Check-in", typeof(string));
            dt.Columns.Add("Ngày Check-out dự tính", typeof(string));
            dt.Columns.Add("Ngày Check-out thực tế", typeof(string));
            dt.Columns.Add("Tên khách hàng", typeof(string));
            dt.Columns.Add("SĐT khách hàng", typeof(string));
            dt.Columns.Add("Nhân viên", typeof(string));
            dt.Columns.Add("Trạng thái", typeof(string));
            dt.Columns.Add("Tổng tiền", typeof(decimal));

            using (HotelDataContext db = new HotelDataContext())
            {
                CultureInfo culture = new CultureInfo("vi-VN");

                var query = from res in db.Reservations
                            where res.checkinDate >= fromDate && res.checkinDate <= toDate.AddDays(1)
                            join cus in db.Customers on res.idCustomer equals cus.id
                            join staff in db.Staffs on res.idStaff equals staff.id
                            orderby res.checkinDate ascending
                            select new
                            {
                                idReservation = res.idReservation,
                                roomNum = res.roomNum,
                                accomodationType = res.accomodationType,
                                checkinDate = res.checkinDate,
                                checkoutDateInit = res.checkoutDate,
                                checkoutDateREAL = res.checkoutDateREAL,
                                customerName = cus.fullName,
                                customerPhone = cus.phone,  
                                staffName = staff.fullName,
                                paymentStatus = res.paymentStatus,
                                totalPrice = reservationPayCheck(res.idCustomer, res.idStaff, res.roomNum, res.idReservation, res.checkinDate)
                            };

                foreach (var item in query)
                {
                    switch (item.accomodationType)
                    {
                        case 1:
                            if (item.paymentStatus == true)
                            {
                                dt.Rows.Add(item.idReservation, item.roomNum, "GIỜ",
                                item.checkinDate.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                "NaN",
                                Convert.ToDateTime(item.checkoutDateInit).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                item.customerName, item.customerPhone, item.staffName, "Đã thanh toán", item.totalPrice);
                            }
                            else
                            {
                                dt.Rows.Add(item.idReservation, item.roomNum, "GIỜ",
                                item.checkinDate.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                "NaN", "NaN",
                                item.customerName, item.customerPhone, item.staffName, "Đang sử dụng", item.totalPrice);
                            }
                            break;

                        case 2:
                            if (item.paymentStatus == true)
                            {
                                dt.Rows.Add(item.idReservation, item.roomNum, "ĐÊM",
                                item.checkinDate.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateInit).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateREAL).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                item.customerName, item.customerPhone,  item.staffName, "Đã thanh toán", item.totalPrice);
                            }
                            else
                            {
                                dt.Rows.Add(item.idReservation, item.roomNum, "ĐÊM",
                                Convert.ToDateTime(item.checkinDate).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateInit).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                "NaN",
                                item.customerName, item.customerPhone, item.staffName, "Đang sử dụng", item.totalPrice);
                            }
                            break;

                        case 3:
                            if (item.paymentStatus == true)
                            {
                                dt.Rows.Add(item.idReservation, item.roomNum, "NGÀY",
                                item.checkinDate.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateInit).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateREAL).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                item.customerName, item.customerPhone, item.staffName, "Đã thanh toán", item.totalPrice);
                            }
                            else
                            {
                                dt.Rows.Add(item.idReservation, item.roomNum, "NGÀY",
                                Convert.ToDateTime(item.checkinDate).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateInit).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                "NaN",
                                item.customerName, item.customerPhone, item.staffName, "Đang sử dụng", item.totalPrice);
                            }
                            break;

                    }
                }
                return dt;
            }
        }

        public static DataTable GetReservationByCustomerID(string customerID)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã đặt phòng", typeof(string));
            dt.Columns.Add("Số phòng", typeof(int));
            dt.Columns.Add("Loại hình", typeof(string));
            dt.Columns.Add("Ngày Check-in", typeof(string));
            dt.Columns.Add("Ngày Check-out dự tính", typeof(string));
            dt.Columns.Add("Ngày Check-out thực tế", typeof(string));
            dt.Columns.Add("Tên khách hàng", typeof(string));
            dt.Columns.Add("SĐT khách hàng", typeof(string));
            dt.Columns.Add("Nhân viên", typeof(string));
            dt.Columns.Add("Trạng thái", typeof(string));
            dt.Columns.Add("Tổng tiền", typeof(decimal));

            using (HotelDataContext db = new HotelDataContext())
            {
                CultureInfo culture = new CultureInfo("vi-VN");

                var query = from res in db.Reservations
                            where res.idCustomer.Equals(customerID) && res.paymentStatus == true
                            join cus in db.Customers on res.idCustomer equals cus.id
                            join staff in db.Staffs on res.idStaff equals staff.id
                            orderby res.checkinDate ascending
                            select new
                            {
                                idReservation = res.idReservation,
                                roomNum = res.roomNum,
                                accomodationType = res.accomodationType,
                                checkinDate = res.checkinDate,
                                checkoutDateInit = res.checkoutDate,
                                checkoutDateREAL = res.checkoutDateREAL,
                                customerName = cus.fullName,
                                customerPhone = cus.phone,
                                staffName = staff.fullName,
                                paymentStatus = res.paymentStatus,
                                totalPrice = reservationPayCheck(res.idCustomer, res.idStaff, res.roomNum, res.idReservation, res.checkinDate)
                            };

                foreach (var item in query)
                {
                    switch (item.accomodationType)
                    {
                        case 1:
                            if (item.paymentStatus == true)
                            {
                                dt.Rows.Add(item.idReservation, item.roomNum, "GIỜ",
                                item.checkinDate.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                "NaN",
                                Convert.ToDateTime(item.checkoutDateInit).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                item.customerName, item.customerPhone, item.staffName, "Đã thanh toán", item.totalPrice);
                            }
                            
                            break;

                        case 2:
                            if (item.paymentStatus == true)
                            {
                                dt.Rows.Add(item.idReservation, item.roomNum, "ĐÊM",
                                item.checkinDate.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateInit).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateREAL).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                item.customerName, item.customerPhone, item.staffName, "Đã thanh toán", item.totalPrice);
                            }
                            
                            break;

                        case 3:
                            if (item.paymentStatus == true)
                            {
                                dt.Rows.Add(item.idReservation, item.roomNum, "NGÀY",
                                item.checkinDate.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateInit).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                Convert.ToDateTime(item.checkoutDateREAL).ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.GetCultureInfo("vi-VN")),
                                item.customerName, item.customerPhone,item.staffName, "Đã thanh toán", item.totalPrice);
                            }
                           
                            break;

                    }
                }
                return dt;
            }
        }

        public static bool InsertReservation(short roomNum, short accomType, 
                                           DateTime checkIn, DateTime checkOut,string idCus, string idStaff)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                try
                {
                    db.USP_InsertReservation(roomNum, accomType, checkIn, checkOut.AddDays(1), null, idCus, idStaff, 0, false, "");
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }

        public static bool UpdateReservation(string idRes, short roomNum, short accomType,
                                           DateTime checkIn, DateTime checkOutInit, DateTime? checkoutReal, 
                                           string idCus, string idStaff, decimal total, bool status, string info)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                var nv = (from staff in db.Reservations
                          where staff.idReservation.Equals(idRes)
                          select staff).First();

                nv.roomNum = roomNum;
                nv.accomodationType = accomType;
                nv.checkinDate= checkIn;
                nv.checkoutDateREAL= checkoutReal;
                nv.checkoutDate = checkOutInit;
                nv.idCustomer= idCus;   
                nv.idStaff= idStaff;
                nv.totalPrice= total;
                nv.paymentStatus= status;
                nv.paymentInfo = info;

                //ask the datacontext to save all the changes
                try
                {
                    db.SubmitChanges();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }

        public static bool CloseProcessingReservation(string idRes, short roomNum, short accomType,
                                           DateTime checkIn, DateTime checkOutInit, DateTime? checkoutReal, decimal totalPrice, string info)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                //ask the datacontext to save all the changes
                try
                {                 
                    db.USP_CloseProcessingReservation(idRes, roomNum, accomType, checkIn, checkOutInit, checkoutReal, 0, info);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }

        public static Reservation FindProcessingReservationByRoomNum(short roomNum)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                //ask the datacontext to save all the changes
                try
                {
                    var nv = (from staff in db.Reservations
                             where staff.roomNum == roomNum && staff.paymentStatus == false
                             select staff).First();

                    return nv;
                }
                catch 
                {
                    MessageBox.Show("Không tìm thấy đơn đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    return null;
                }
            }
        }

        public static bool CloseProcessingReservationAndChangeRoom(string idRes, short roomNum, short accomType,
                                           DateTime checkIn, DateTime checkOutInit, DateTime? checkoutReal, decimal totalPrice, string info, 
                                           short newRoomNum, short newAccoType, DateTime newCheckIn, DateTime newCheckOutInit, string idStaff, string idCus)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                //ask the datacontext to save all the changes
                try
                {
                    db.USP_CloseProcessingReservationAndChangeRoom(idRes, roomNum, accomType, checkIn, checkOutInit, checkoutReal, 0, info, newRoomNum, newAccoType, newCheckIn, newCheckOutInit,idCus, idStaff, totalPrice);

                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }

    }
}
