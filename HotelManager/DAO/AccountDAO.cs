using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelManager.DAO
{
    public class AccountDAO
    {
        public AccountDAO() { }

        private static string Encrytion(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                return sb.ToString();
            }
        }

        public static List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from account in db.Accounts
                            select account;

                foreach (var item in query)
                {
                    accounts.Add(item);
                }
            }
            return accounts;
        }

        //public bool UpdatePassword(string email, string password)
        //{
        //    password = Encrytion(password);
        //    return dalEmployee.UpdatePassword(email, password);
        //}

        //public bool ChangePassword(string email, string oldPassword, string newPassword)
        //{
        //    oldPassword = Encrytion(oldPassword);
        //    newPassword = Encrytion(newPassword);
        //    return dalEmployee.ChangePassword(email, oldPassword, newPassword);
        //}


        public static Account GetAccountByUserName(string userName)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from tk in db.Accounts
                            where tk.userName.Equals(userName)
                            select tk;

                return query.FirstOrDefault();
            }
        }

        public static bool DecreaseAttempsOrLockAccount(string userName)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                try
                {
                    db.USP_DecreaseAttempsOrLockAccount(userName);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }

        public static bool ResetAttempsOrUnlockAccount(string userName)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                try
                {
                    db.USP_ResetAttempsOrUnlockAccount(userName);
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }
        }

        public static void DeleteAccountByUserNameOfStaff(string userName)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                var deleteAccount = from account in db.Accounts
                                    where account.userName.Equals(userName) && account.type == 2
                                    select account;

                foreach (var account in deleteAccount)
                {
                    db.Accounts.DeleteOnSubmit(account);
                }

                try
                {
                    db.SubmitChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public static bool UpdatePassword(string email, string oldPassword, string newPass)
        {
            using (HotelDataContext db = new HotelDataContext())
            {
                try
                {
                    db.USP_UpdatePassword(email, oldPassword, newPass);
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
