using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Department
    {
        private string departmentName;
        private List<Employee> employees;

        //fields
        //initialization
        public Department(string departmentName)
        {
            this.departmentName = departmentName;
            this.employees = new List<Employee>();
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

        public List<Employee> GetEmployee()
        {
            return employees;
        }

        public override string ToString()
        {
            return "Dept Name:" + DepartmentName;

        }
    }
}
