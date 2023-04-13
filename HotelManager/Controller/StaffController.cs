using HotelManager.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Controller
{
    public class StaffController
    {
        public static DataTable GetStaffList()
        {
            DataTable staffs = StaffDAO.GetListStaff();

            return staffs;
        }

        public static Staff GetStaffById(string staffID)
        {
            return StaffDAO.GetStaffById(staffID);
        }

        public static Staff GetStaffByUserName(string staffID)
        {
            return StaffDAO.GetStaffByUserName(staffID);
        }

        public static bool InsertStaff(string hoTen, DateTime ngaySinh, string diaChi, string sdt, string cmnd)
        {
            return StaffDAO.InsertStaff(hoTen, ngaySinh, diaChi, sdt, cmnd);
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

        public static bool LockOrUnLockStaffAccount(string userName)
        {
            return StaffDAO.LockOrUnLockStaffAccount(userName);
        }

    }
}
