using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project
{
    public class Account
    {
        protected int userID;
        protected string password;
        protected string userName;
        protected bool accountSecurity;

        public int UserID 
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        //regex
        public bool SetPassword(string password)
        {
            if (Regex.IsMatch(password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,15}$"))
            {
                this.password = password;
                return true;
            }
            return false;
        }

        public string GetPassword()
        {
            return password;
        }
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }

        public bool AccountSecurity
        {
            get
            {
                return accountSecurity;
            }
            set
            {
                accountSecurity = value;
            }
        }

        //public string GetFormAccess(Role role)
        //{
        //    return role.FormAccess;
        //}

    }
}
