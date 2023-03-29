using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DAO
{
    public class RoomDAO
    {

        public RoomDAO() { }

        public static int RoomBtnWidth = 80;
        public static int RoomBtnHeight = 80;

        public static List<Room> LoadRoomList()
        {
            List<Room> roomList = new List<Room>();

            using(HotelDataContext db = new HotelDataContext())
            {
                var query = from cr in db.Rooms
                            select cr;
                foreach (var item in query)
                {
                    roomList.Add(item);
                }
            }
            return roomList;
        }
    }
}
