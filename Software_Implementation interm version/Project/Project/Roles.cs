using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Roles
    {
        private string roleName;
        private int roleID;
        private List<Employee> employees;

        //fields
        //initialization

        public Roles(string roleName, int roleID)
        {
            this.roleName = roleName;
            this.roleID = roleID;
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

    }
}
