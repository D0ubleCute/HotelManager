using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DAO
{
    public class AccountDAO
    {
        private AccountDAO() { }

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
    }
}
