using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Role
    {
        private string roleName;
        private int roleID;
        private string formAccess;
        private List<Employee> employees;

        //fields
        //initialization
        public Role()
        {
            this.RoleName = roleName;
            this.FormAccess = formAccess;
            this.employees = new List<Employee>();
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

        public string RoleName
        {
            get
            {
                return roleName;
            }
            set
            {
                roleName = value;
            }
        }

        public string FormAccess
        {
            get
            {
                return formAccess;
            }
            set
            {
                formAccess = value;
            }
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public List<Employee> GetAllEmployee()
        {
            return this.employees;
        }

        public override string ToString()
        {
            return $"{RoleID} {RoleName}";
        }

    }
}
