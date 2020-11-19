using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Department
    {
        private int departmentNumber;
        private string departmentName;
        private List<Employee> employees;

        //fields
        //initialization

        public Department(int departmentNumber, string departmentName)
        {
            this.departmentNumber = departmentNumber;
            this.departmentName = departmentName;
            this.employees = new List<Employee>();
        }

        public int DepartmentID
        {
            get
            {
                return departmentNumber;
            }
            set
            {
                departmentNumber = value;
            }
        }

        public string DepartmentName
        {
            get
            {
                return departmentName;
            }
            set
            {
                departmentName = value;
            }
        }

        public void AddEmployee(Employee employee)
        {
            this.employees.Add(employee);
        }

        public List<Employee> GetEmployee()
        {
            return employees;
        }

        public override string ToString()
        {
            return "Dept Name:" + DepartmentName +
                 " dept no. " + DepartmentID;

        }
    }
}
