using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project
{

    public class Employee : Account
    {
        protected string firstName;
        protected string lastName;
        protected string DOB;
        protected string email;
        protected int phoneNo;
        protected string nationality;
        protected string city;
        protected string ZipCode;
        protected string address;
        protected int salary;
        protected string hireDate;
        protected int department;
        protected int roleID;
        public Employee(int userID, string password, string userName, string firstName, string lastName, string email, int phoneNo,
                         string nationality, string city, string ZipCode, string DOB, string hireDate, string address, int department, int roleID, int salary)
        {
            base.UserID = userID;
            base.Password = password;
            base.UserName = userName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNo = phoneNo;
            this.nationality = nationality;
            this.city = city;
            this.ZipCode = ZipCode;
            this.DOB = DOB;
            this.hireDate = hireDate;
            this.address = address;
            this.department = department;
            this.roleID = roleID;
            this.salary = salary;
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
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public int PhoneNO
        {
            get
            {
                return phoneNo;
            }
            set
            {
                phoneNo = value;
            }
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
        public int EmployeeDepartment
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
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
        public int RoleID
        {
            get
            {
                return roleID;
            }
            set
            {
                roleID = value;
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
    }
}
