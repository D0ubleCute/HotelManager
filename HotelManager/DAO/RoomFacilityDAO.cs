using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.DAO
{
    public class RoomFacilityDAO
    {
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

            foreach (RoomFacility item in facilityListPerRoom)
            {
                listFacility += item.nameFacility.ToString() + "  ";
            }
            return listFacility;
        }

        public static bool InsertRoomFacility(short roomNum, string nameFacility)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                try
                {
                    db.USP_InsertRoomFacility(nameFacility, roomNum);
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
