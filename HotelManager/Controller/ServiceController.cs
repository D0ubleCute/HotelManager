using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManager.DAO;

namespace HotelManager.Controller
{
    public class ServiceController
    {
        public static List<RoomExtra> GetRoomService()
        {
            return ServiceDAO.GetRoomService();
        }

        public static DataTable GetRoomServiceList()
        {
            return ServiceDAO.GetRoomServiceList();
        }

        public static bool UpdateService(string id, string serviceName, int servicePrice)
        {
            return ServiceDAO.UpdateService(id, serviceName, servicePrice);
        }
    }
}
