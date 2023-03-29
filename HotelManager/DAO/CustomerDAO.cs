using HotelManager.DAO;
using HotelManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace HotelManager.DAO
{
    public class CustomerDAO
    {
        public static List<Customer> GetCustomer()
        {
            List<Customer> customerList = new List<Customer>();

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from cus in db.Customers
                            select cus;

                foreach (var item in query)
                {
                    customerList.Add(item);
                }
            }

            return customerList;
        }

        public static DataTable GetCustomerList()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã khách hàng", typeof(string));
            dt.Columns.Add("Họ tên", typeof(string));
            dt.Columns.Add("Ngày sinh", typeof(DateTime));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("SĐT", typeof(string));
            dt.Columns.Add("CMND", typeof(string));
            dt.Columns.Add("Tổng điểm", typeof(int));

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from cus in db.Customers select cus;

                foreach (var item in query)
                {
                    dt.Rows.Add(item.id, item.fullName, item.dob, item.email, item.phone.Trim(), item.cmnd.Trim(), item.points); ;
                }
            }
            return dt;
        }

        public static bool UpdateStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, string cmnd)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                var nv = (from staff in db.Staffs
                          where staff.id.Equals(id)
                          select staff).First();

                nv.fullName = hoTen;
                nv.dob = ngaySinh;
                nv.address = diaChi;
                nv.phone = sdt;
                nv.cmnd = cmnd;

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


        //public static DataTable SearchStaffByName(string name)
        //{
        //    DataTable dt = new DataTable();

        //    dt.Columns.Add("Mã nhân viên", typeof(string));
        //    dt.Columns.Add("Họ tên", typeof(string));
        //    dt.Columns.Add("Ngày sinh", typeof(DateTime));
        //    dt.Columns.Add("Địa chỉ", typeof(string));
        //    dt.Columns.Add("SĐT", typeof(string));
        //    dt.Columns.Add("CMND", typeof(string));
        //    dt.Columns.Add("Tài khoản", typeof(string));

        //    using (HotelDataContext db = new HotelDataContext())
        //    {
        //        var query = db.USP_SearchStaff(name);

        //        foreach (var item in query)
        //        {
        //            dt.Rows.Add(item.id, item.fullName, item.dob, item.address, item.phone.Trim(), item.cmnd.Trim(), item.userName);
        //        }
        //    }

        //    return dt;
        //}
    }
}
