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

        public static List<RoomExtraCategory> GetRoomServiceCategory()
        {
            return ServiceDAO.GetRoomServiceCategory();
        }

        public static List<RoomExtra> GetRoomServiceByCategory(string idCategory)
        {
            return ServiceDAO.GetRoomServiceByCategory(idCategory);
        }

        public static DataTable GetRoomServiceList()
        {
            return ServiceDAO.GetRoomServiceList();
        }

        public static bool InsertAlreadyService(string idCategory, string idService, string nameService, int priceService)
        {
            return ServiceDAO.InsertAlreadyService(idCategory, idService, nameService, priceService);
        }

        public static bool InsertNewService(string idCategory, string nameCategory, string idService, string nameService, int priceService)
        {
            return ServiceDAO.InsertNewService(idCategory, nameCategory, idService, nameService, priceService);
        }

        public static bool UpdateService(string id, string serviceName, int servicePrice)
        {
            return ServiceDAO.UpdateService(id, serviceName, servicePrice);
        }
    }
}
