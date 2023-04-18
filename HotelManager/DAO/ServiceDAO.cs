using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.DAO
{
    public class ServiceDAO
    {
        public static List<RoomExtra> GetRoomService()
        {
            List<RoomExtra> serviceList = new List<RoomExtra>();

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from rs in db.RoomExtras
                            select rs;

                foreach (var item in query)
                {
                    serviceList.Add(item);
                }
            }

            return serviceList;
        }

        public static List<RoomExtraCategory> GetRoomServiceCategory()
        {
            List<RoomExtraCategory> serviceList = new List<RoomExtraCategory>();

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from rs in db.RoomExtraCategories
                            select rs;

                foreach (var item in query)
                {
                    serviceList.Add(item);
                }
            }

            return serviceList;
        }

        public static DataTable GetRoomServiceList()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã dịch vụ", typeof(string));
            dt.Columns.Add("Tên dịch vụ", typeof(string));
            dt.Columns.Add("Giá dịch vụ", typeof(string));

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from cus in db.RoomExtras select cus;

                foreach (var item in query)
                {
                    dt.Rows.Add(item.idService, item.nameService, item.priceService); ;
                }
            }
            return dt;
        }

        public static List<RoomExtra> GetRoomServiceByCategory(string idCategory)
        {
            List<RoomExtra> serviceList = new List<RoomExtra>();

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from rs in db.RoomExtras 
                            where rs.idCategory.Equals(idCategory)
                            select rs;

                foreach (var item in query)
                {
                    serviceList.Add(item);
                }
            }

            return serviceList;
        }

        public static bool InsertService(string hoTen, DateTime ngaySinh, string diaChi, string sdt, string cmnd)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                try
                {
                    db.USP_InsertStaff(hoTen, ngaySinh, diaChi, sdt, cmnd);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }

        public static bool DeleteService(string idService)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                var query = (from staff in db.RoomExtras
                             where staff.idService.Equals(idService)
                             select staff).First();

                db.RoomExtras.DeleteOnSubmit(query);

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

        public static bool UpdateService(string id, string serviceName, int servicePrice)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                var nv = (from staff in db.RoomExtras
                          where staff.idService.Equals(id)
                          select staff).First();

                nv.nameService = serviceName;
                nv.priceService = servicePrice;

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
