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
using System.Globalization;

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
            dt.Columns.Add("Ngày sinh", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("SĐT", typeof(string));
            dt.Columns.Add("CMND", typeof(string));
            dt.Columns.Add("Tổng điểm", typeof(int));

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from cus in db.Customers select cus;

                foreach (var item in query)
                {
                    dt.Rows.Add(item.id, item.fullName, Convert.ToDateTime(item.dob).ToString("dd/MM/yyyy", CultureInfo.GetCultureInfo("vi-VN")), item.email, item.phone.Trim(), item.cmnd.Trim(), item.points); ;
                }
            }
            return dt;
        }

        public static Customer GetCustomerByPhone(string phone)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                try
                {
                    var nv = (from staff in db.Customers
                              where staff.phone.Equals(phone)
                              select staff).First();
                    return nv;
                } catch
                {
                    return null;
                }
            }
        }

        public static Customer GetCustomerById(string cusID)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                try
                {
                    var nv = (from staff in db.Customers
                              where staff.id.Equals(cusID)
                              select staff).First();

                    return nv;
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }
            }
        }

        public static DataTable SearchCustomerByName(string name)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Mã khách hàng", typeof(string));
            dt.Columns.Add("Họ tên", typeof(string));
            dt.Columns.Add("Ngày sinh", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("SĐT", typeof(string));
            dt.Columns.Add("CMND", typeof(string));
            dt.Columns.Add("Tổng điểm", typeof(int));

            using (HotelDataContext db = new HotelDataContext())
            {
                var item = (from staff in db.Customers
                          where staff.fullName.Equals(name)
                          select staff).First();

                dt.Rows.Add(item.id, item.fullName, Convert.ToDateTime(item.dob).ToString("dd/MM/yyyy", CultureInfo.GetCultureInfo("vi-VN")), item.email, item.phone.Trim(), item.cmnd.Trim(), item.points);
            }
            return dt;
        }

        public static bool InsertCustomer(string hoTen, DateTime ngaySinh, string email, string address, string sdt, string cmnd)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                try
                {
                    db.USP_InsertCustomer(hoTen, ngaySinh,email, address, sdt, cmnd);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }

        public static bool UpdateCustomer(string id, string hoTen, DateTime ngaySinh, string email, string sdt, string cmnd)
            {
                using (HotelDataContext db = new HotelDataContext())
                {
                    var nv = (from staff in db.Customers
                              where staff.id.Equals(id)
                              select staff).First();

                    nv.fullName = hoTen;
                    nv.dob = ngaySinh;
                    nv.email = email;
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
