using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManager.DAO;

namespace HotelManager.Controller
{
    public class CustomerController
    {
        public static DataTable GetCustomerList()
        {
            DataTable customerList = CustomerDAO.GetCustomerList();

            return customerList;
        }

        public static bool UpdateStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, string cmnd)
        {
            return StaffDAO.UpdateStaff(id, hoTen, ngaySinh, diaChi, sdt, cmnd);
        }

        public static bool DeleteStaff(string userName)
        {
            return StaffDAO.DeleteStaff(userName);
        }

        public static DataTable SearchStaffByName(string staffName)
        {
            DataTable searchStaffList = StaffDAO.SearchStaffByName(staffName);

            return searchStaffList;
        }

        //public static NhanVien GetStaffById(string staffId)
        //{
        //    return StaffDAO.GetStaffByID(staffId);
        //}
    }
}
