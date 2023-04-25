using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DAO
{
    public class RoomThingDAO
    {
        public static List<RoomThing> GetRoomThings()
        {
            List<RoomThing> roomThings = new List<RoomThing>();

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from room in db.RoomThings
                            select room;
                foreach (var item in query)
                {
                    roomThings.Add(item);
                }
            }
            return roomThings;
        }

        public static DataTable GetRoomThingsTable()
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("Mã vật tư", typeof(string));
            dt.Columns.Add("Tên vật tư", typeof(string));
            dt.Columns.Add("Số lượng", typeof(short));
            dt.Columns.Add("Tình trạng", typeof(short));

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from room in db.VatTus
                            select room;
                foreach(var item in query)
                {
                    dt.Rows.Add(item.idVatTu, item.nameVatTu, item.qtyVatTu, item.statusVatTu);
                }

            }
            return dt;
        }

            public static List<RoomThing> GetRoomThingsByRoomNum(short roomNum)
            {
                List<RoomThing> roomThings = new List<RoomThing>();

                using (HotelDataContext db = new HotelDataContext())
                {
                    var query = from room in db.RoomThings
                                where room.roomNum == roomNum
                                select room;
                    foreach (var item in query)
                    {
                        roomThings.Add(item);
                    }
                }
                return roomThings;
            }

            public static DataTable GetRoomThingsTableByRoomNum(short roomNum)
            {

                DataTable dt = new DataTable();

                dt.Columns.Add("Phòng", typeof(short));
                dt.Columns.Add("Tên đồ dùng", typeof(string));
                dt.Columns.Add("Số lượng", typeof(short));

                using (HotelDataContext db = new HotelDataContext())
                {
                    var query = from room in db.RoomThings
                                where room.roomNum == roomNum
                                select room; 

                    foreach (var item in query)
                    {
                        VatTu vatTu = VatTuDAO.GetVatTu(item.idVatTu);
                        dt.Rows.Add(roomNum, vatTu.nameVatTu, item.qtyVatTuByRoom);
                    }
                }

                return dt;
            }
    }
}
