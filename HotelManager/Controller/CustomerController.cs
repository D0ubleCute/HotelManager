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
    public class CustomerController
    {
        public static DataTable GetCustomerList()
        {
            DataTable customerList = CustomerDAO.GetCustomerList();

            return customerList;
        }

        public static Customer GetCustomerByPhone(string cusPhone)
        {
            return CustomerDAO.GetCustomerByPhone(cusPhone);   
        }

        public static Customer GetCustomerById(string cusId)
        {
            return CustomerDAO.GetCustomerById(cusId);
        }

        public static bool InsertCustomer(string hoTen, DateTime ngaySinh, string email, string address, string sdt, string cmnd)
        {
            return CustomerDAO.InsertCustomer(hoTen, ngaySinh, email, address, sdt, cmnd);
        }

        public static bool UpdateCustomer(string id, string hoTen, DateTime ngaySinh, string email, string sdt, string cmnd)
        {
            return CustomerDAO.UpdateCustomer(id, hoTen, ngaySinh, email, sdt, cmnd);
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
