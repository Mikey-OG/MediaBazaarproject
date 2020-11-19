using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Project
{

    public class Employee : Account 
    {
        private string firstName;
        private string lastName;
        private string DOB;
        private string email;
        private string phoneNo;
        private string nationality;
        private string city;
        private string ZipCode;
        private string address;
        private int salary;
        private string hireDate;
        private string dismissDate;
        public Employee(string userName, string firstName, string lastName, string nationality, string city,
            string ZipCode, string DOB, string hireDate, string address, string formAccess, int salary)
        {
            base.UserName = userName;
            base.FormAccess = formAccess;
            this.firstName = firstName;
            this.lastName = lastName;
            this.nationality = nationality;
            this.city = city;
            this.ZipCode = ZipCode;
            this.DOB = DOB;
            this.hireDate = hireDate;
            this.address = address;  
            this.salary = salary;
        }
        public Employee(string userName, string firstName, string lastName, string nationality, string city,
           string ZipCode, string DOB, string hireDate, string address, string formAccess, int salary, string dismissDate)
        {
            base.UserName = userName;
            base.FormAccess = formAccess;
            this.firstName = firstName;
            this.lastName = lastName;
            this.nationality = nationality;
            this.city = city;
            this.ZipCode = ZipCode;
            this.DOB = DOB;
            this.hireDate = hireDate;
            this.address = address;
            this.salary = salary;
            this.dismissDate = dismissDate;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                lastName = value;
            }
        }

        //Regex
        public bool SetEmail(string givenEmail)
        {
            if(Regex.IsMatch(givenEmail, "^[a-z0-9A-Z]{5,20}@[a-z]{3,8}.(com|org|in|nl)$"))
            {
                this.email = givenEmail;
                return true;
            }
            return false;
        }

        public string GetEmail()
        {
            return email;
        }


        //Regex
        public bool SetPhoneNO(string phone)
        {
            if (Regex.IsMatch(phone, "^(\\+)[0-9]{1,4}[0-9]{5,15}$"))
            {
                this.phoneNo = phone;
                return true;
            }
            return false;
        }

        public string GetPhoneNo()
        {
            return phoneNo;
        }


        public string Nationality
        {
            get
            {
                return nationality;
            }
            set
            {
                nationality = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Zipcode
        {
            get
            {
                return ZipCode;
            }
            set
            {
                ZipCode = value;
            }
        }
        public string DateOfBirth
        {
            get
            {
                return DOB;
            }
            set
            {
                DOB = value;
            }
        }
        public string HireDate
        {
            get
            {
                return hireDate;
            }
            set
            {
                hireDate = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        public string DismissDate
        {
            get
            {
                return dismissDate;
            }
            set
            {
                dismissDate = value;
            }
        }
    }
}
