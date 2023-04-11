using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DAO
{
    public class ServiceReservationByRoomDAO
    {
        public static List<RoomExtraByRoom> GetRoomService()
        {
            List<RoomExtraByRoom> serviceListByRoom = new List<RoomExtraByRoom>();

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from rs in db.RoomExtraByRooms
                            select rs;

                foreach (var item in query)
                {
                    serviceListByRoom.Add(item);
                }
            }

            return serviceListByRoom;
        }

        public static DataTable GetRoomServiceList()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã đặt dịch vụ", typeof(string));
            dt.Columns.Add("Mã dịch vụ", typeof(string));
            dt.Columns.Add("Số phòng", typeof(short));
            dt.Columns.Add("Mã đặt phòng", typeof(string));

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from cus in db.RoomExtraByRooms select cus;

                foreach (var item in query)
                {
                    dt.Rows.Add(item.idServiceIm, item.idService, item.roomNum, item.idReservation); ;
                }
            }
            return dt;
        }

        public static DataTable GetRoomServiceListByReservation(string idRes)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã đặt dịch vụ", typeof(string));
            dt.Columns.Add("Mã dịch vụ", typeof(string));
            dt.Columns.Add("Số phòng", typeof(short));
            dt.Columns.Add("Mã đặt phòng", typeof(string));
            dt.Columns.Add("Tên dịch vụ", typeof(string));
            dt.Columns.Add("Giá thành", typeof(int));

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = db.USP_GetRoomExtraPriceByReservation(idRes);

                foreach (var item in query)
                {
                    dt.Rows.Add(item.idServiceIm, item.idService, item.roomNum, item.idReservation, item.nameService, item.priceService); ;
                }
            }
            return dt;
        }
    }
}
