﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelManager.DAO
{
        public class StaffDAO
        {
            

        public static List<Staff> GetStaff()
            {
                List<Staff> staffList = new List<Staff>();

                using (HotelDataContext db = new HotelDataContext())
                {
                    var query = from nv in db.Staffs
                                select nv;

                    foreach (var item in query)
                    {
                        staffList.Add(item);
                    }
                }

                return staffList;
            }

            public static DataTable GetListStaff()
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("Mã nhân viên", typeof(string));
                dt.Columns.Add("Họ tên", typeof(string));
                dt.Columns.Add("Ngày sinh", typeof(string));
                dt.Columns.Add("Địa chỉ", typeof(string));
                dt.Columns.Add("SĐT", typeof(string));
                dt.Columns.Add("CMND", typeof(string));
                dt.Columns.Add("Tài khoản", typeof(string));
                dt.Columns.Add("Trạng thái", typeof(string));

                using (HotelDataContext db = new HotelDataContext())
                {
                    var query = db.USP_GetStaff();
                                
                    foreach (var item in query)
                    {
                        var query2 = (from acc in db.Accounts
                                 where acc.userName.Equals(item.userName)
                                     select acc);
                        foreach (var item2 in query2)
                    {
                        if (item2.isLocked == true)
                        {
                            dt.Rows.Add(item.id, item.fullName, item.dob.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture), item.address, item.phone, item.cmnd, item.userName, "Đã khoá");
                            break;
                        }
                        dt.Rows.Add(item.id, item.fullName, item.dob.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture), item.address, item.phone, item.cmnd, item.userName, "Hoạt động");
                        break;
                    }
                }
                    
                    }
                return dt;
            }

            public static Staff GetStaffById(string staffID)
            {
                List<Staff> staffList = GetStaff();

                foreach (var item in staffList)
                {
                    if (item.id.Equals(staffID))
                    {
                        return item;
                    }
                }
                return null;
            }

        public static Staff GetStaffByUserName(string userName)
        {
            List<Staff> staffList = GetStaff();

            foreach (var item in staffList)
            {
                if (item.userName.Equals(userName))
                {
                    return item;
                }
            }
            return null;
        }

        public static DataTable SearchStaffByName(string name)
            {
                DataTable dt = new DataTable();

                dt.Columns.Add("Mã nhân viên", typeof(string));
                dt.Columns.Add("Họ tên", typeof(string));
                dt.Columns.Add("Ngày sinh", typeof(DateTime));
                dt.Columns.Add("Địa chỉ", typeof(string));
                dt.Columns.Add("SĐT", typeof(string));
                dt.Columns.Add("CMND", typeof(string));
                dt.Columns.Add("Tài khoản", typeof(string));

                using (HotelDataContext db = new HotelDataContext())
                {
                    var query = db.USP_SearchStaff(name);

                    foreach (var item in query)
                    {
                        dt.Rows.Add(item.id, item.fullName, item.dob, item.address, item.phone.Trim(), item.cmnd.Trim(), item.userName);
                    }
                }
                return dt;
            }


            public static bool InsertStaff(string hoTen, DateTime ngaySinh, string diaChi, string sdt, string cmnd, string pass, int count)
                {
                    using (HotelDataContext db = new HotelDataContext())
                    {
                        try
                        {
                            db.USP_InsertStaff(hoTen, ngaySinh, diaChi, sdt, cmnd, pass, count);
                            return true;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                            return false;
                        }
                    }
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

            public static bool DeleteStaff(string userName)
            {
                AccountDAO.DeleteAccountByUserNameOfStaff(userName);

                using (HotelDataContext db = new HotelDataContext())
                {
                    var query = (from staff in db.Staffs
                                 where staff.id.Equals(userName)
                                 select staff).First();

                    db.Staffs.DeleteOnSubmit(query);

                    var item = query.userName;
                    {
                        var query2 = (from acc in db.Accounts
                                      where acc.userName.Equals(item)
                                      select acc).First();

                    db.Accounts.DeleteOnSubmit(query2);
                    }   

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

        public static bool LockOrUnLockStaffAccount(string username)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                try
                {
                    var query = (from staff in db.Staffs
                                 where staff.id.Equals(username)
                                 select staff);

                    foreach (var item in query)
                    {
                        var query_2 = (from acc in db.Accounts
                                       where acc.userName.Equals(item.userName)
                                       select acc);
                        foreach (var item_2 in query_2)
                        {
                            if (item_2.isLocked)
                            {
                                db.USP_ResetAttempsOrUnlockAccount(item_2.userName);
                            } else
                            {
                                db.USP_LockWantedAccount(item_2.userName);
                            }
                        }
                        return true;
                    }
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
