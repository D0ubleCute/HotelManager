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

        public static Customer GetCustomerByPhone(string phone)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                var nv = (from staff in db.Customers
                          where staff.phone.Equals(phone)
                          select staff).First();
                return nv;
            }
        }

        public static Customer GetCustomerById(string cusID)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                var nv = (from staff in db.Customers
                          where staff.id.Equals(cusID)
                          select staff).First();

                return nv;
            }
        }

        public static bool UpdateCustomer(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, string cmnd)
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
    }
}
