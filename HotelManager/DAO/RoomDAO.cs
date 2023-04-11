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
        public static int RoomBtnWidth = 164;
        public static int RoomBtnHeight = 164;

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

        public static Room loadRoomByRoomNum(int roomNum)
        {
            Room room= new Room();

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from cr in db.Rooms
                            where cr.roomNum== roomNum
                            select cr;
                foreach (var item in query)
                    room = item;
            }
            return room;
        }

        public static List<RoomFacility> getRoomFacility(int roomNum)
        {
            List<RoomFacility> facilityListPerRoom = new List<RoomFacility>();

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from room in db.RoomFacilities
                            where room.roomNum == roomNum
                            select room; 
                foreach (var item in query)
                {
                    facilityListPerRoom.Add(item);
                }
            }
            return facilityListPerRoom;
        }

        public static string loadRoomFacility(int roomNum)
        {
            List<RoomFacility> facilityListPerRoom = getRoomFacility(roomNum);
            string listFacility = "";

            foreach(RoomFacility item in facilityListPerRoom)
            {
                listFacility += item.nameFacility.ToString() + "  ";
            }
            return listFacility;
        }
    }
}
