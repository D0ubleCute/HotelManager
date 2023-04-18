using HotelManager.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Controller
{
    public class RoomController
    {
        public static List<Room> GetRoomList()
        {
            List<Room> rooms = RoomDAO.LoadRoomList();

            return rooms;
        }

        public static Room loadRoombyRoomNum(int roomNum) { 
            return RoomDAO.loadRoomByRoomNum(roomNum); ;
        }

        public static List<RoomFacility> getRoomFacility(int roomNum)
        {
            return RoomDAO.getRoomFacility(roomNum); 
        }

        public static string loadRoomFacility(int roomNum)
        {
            return RoomDAO.loadRoomFacility(roomNum);   
        }

        public static bool InsertRoom(short roomNum, string roomName, string roomImage, short idType, string typeName, string idRateByType, short area)
        {
            return RoomDAO.InsertRoom(roomNum, roomName, roomImage, idType, typeName, idRateByType, area);
        }

        public static bool UpdateRoom(short roomNum, string roomName, string roomImage, short idType, string typeName, bool isOccupied, bool isClean, string idRateByType, short area)
        {
            return RoomDAO.UpdateRoom(roomNum, roomName, roomImage, idType, typeName, isOccupied, isClean, idRateByType, area);
        }
    }
}
