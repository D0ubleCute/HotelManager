using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Room r = new Room();
            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from cr in db.Rooms
                             where cr.roomNum == roomNum
                             select cr;
                foreach(var item in query)
                {
                    r = item;
                    return r;
                }
                return null;
            }       
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

        public static bool InsertRoom(short roomNum, string roomName, string roomImage, short idType, string typeName, string idRateByType, short area)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                try
                {
                    db.USP_InsertRoom(roomNum, roomName, roomImage, idType, typeName, idRateByType, area);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }

        public static bool UpdateRoom(short roomNum, string roomName, string roomImage, short idType, string typeName, bool isOccupied, bool isClean, string idRateByType, short area)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                var nv = (from staff in db.Rooms
                          where staff.roomNum == roomNum
                          select staff).First();

                nv.roomName = roomName;
                nv.roomImage = roomImage;
                nv.idType = idType;
                nv.typeName = typeName;
                nv.isOccupied = isOccupied;
                nv.isClean = isClean;
                nv.idRateByType = idRateByType;
                nv.area = area;

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
    }
}
