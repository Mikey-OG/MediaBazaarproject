using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL;

namespace Project.LGC
{
    public class LogInClass
    {
        private LoginDAL lgd;
        private List<string> failedLogInAttempts;

        public LogInClass()
        {
            lgd = new LoginDAL();
            failedLogInAttempts = new List<string>();
        }

        public string PrepareLogIn(string password, string userName)
        {
            string UserValidation = lgd.EmployeePriviledge(password, userName);
            if (UserValidation == null)
            {
                return null;
            }
            else
            {
                return UserValidation;
            }
        }

        public string AccountSecurity(string userName)
        {
            if(lgd.CheckAccountSecurity(userName) == false)
            {
                return userName;
            }
            else
            {
                //the user account is safe
                return null;
            }
        }

        public void AddFailedLogInUser(string password, string username)
        {
            failedLogInAttempts.Add(username);
        }

        public bool SuspendAccount()
        {
            if(failedLogInAttempts.Count() > 3)
            {
                return true;
            }
            else
            {
                return false;
            }      
        }

        public bool ChangePassword(string userName, string password)
        {
            if(lgd.ChangePassword(userName, password) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveAllFailedAttempts()
        {
            failedLogInAttempts.Clear();
        }

    }
}
