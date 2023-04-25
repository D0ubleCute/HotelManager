using HotelManager.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Controller
{
    public class AccountController
    {
        public static Account GetAccountByUsername(string username)
        {
            return AccountDAO.GetAccountByUserName(username);
        }

        public static bool Login(string username, string password)
        {
            List<Account> accounts = AccountDAO.GetAccounts();

            foreach (Account item in accounts)
            {
                if (item.userName.Equals(username) && item.password.Equals(password))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool DecreaseAttempsOrLockAccount(string userName)
        {
            return AccountDAO.DecreaseAttempsOrLockAccount(userName);
        }

        public static bool ResetAttempsOrUnlockAccount(string userName)
        {
            return AccountDAO.ResetAttempsOrUnlockAccount(userName);
        }

        public static bool UpdatePassword(string email, string oldPassword, string newPass)
        {
            return AccountDAO.UpdatePassword(email, oldPassword, newPass);  
        }

    }
}

