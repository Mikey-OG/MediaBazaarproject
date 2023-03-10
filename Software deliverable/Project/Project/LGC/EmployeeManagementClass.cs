using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL;

namespace Project.LGC
{
    public class EmployeeManagementClass: IObjectList
    {
        
        private EmployeeManagementDAL emd;
        private List<Employee> employees;
        private List<Employee> dismissedEmployees;
        private List<Role> roles;
        private List<Department> departments;

        public  EmployeeManagementClass()
        {
            employees = new List<Employee>();
            roles = new List<Role>();
            departments = new List<Department>();
            dismissedEmployees = new List<Employee>();
            emd = new EmployeeManagementDAL(); 
        }
        public void InitializeListOfClasses()
        {
            AddAllEmployees();
        }

        public void AddAllEmployees()
        {
            emd.AddToDtbListOfEmployees();
            foreach (var item in emd.GetListOfAllEmployeesFromDatabase())
            {
                employees.Add(item);
            }
        }

        public void AddAllDismissedEmployees()
        {
            emd.AddToDtbListOfDismmisedEmployees();
            foreach (var item in emd.GetAllDismissedEmployeesFromDtb())
            {
                if(!dismissedEmployees.Contains(item))
                {
                    dismissedEmployees.Add(item);
                }          
            }
        }

        public void AddAllRoles()
        { 
            emd.AddAllRolesFromDtb();
            foreach (var item in emd.GetAllRolesFromDtb())
            {
                roles.Add(item);
            }
        }


        public void AddAllDepartments()
        {
            emd.AddAllDepartmentsFromDTB();
            foreach (var item in emd.GetAllDepartmentsFromDtb())
            {
                departments.Add(item);
            }
        }

        public bool EmployeeDoesNotExistInList()
        {
            foreach (var item in emd.GetListOfAllEmployeesFromDatabase())
            {
                if (!employees.Contains(item))
                {
                    employees.Add(item);
                    return true;
                }
            }
            return false;
        }

        public bool AddEmployee(Employee employee)
        {
            if(emd.AddEmployeeToDatabase(employee) == true)
            {
                emd.AddToDtbListOfEmployees();
                if(EmployeeDoesNotExistInList() == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool UpdateEmployee(Employee employee, int UserID)
        {
            if(emd.UpdateEmployeeInDatabase(employee, UserID) == true)
            {
                if(emd.UpdateInDtbListOfEmployees(employee, UserID) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool DismissEmployee(Employee employee, int UserID)
        {
            if(emd.DismissEmployeeInDatabase(employee, UserID) == true)
            {
                if(emd.DismissInDtbListOfEmployees(employee, UserID) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //public bool SearchForEmployee(string name)
        //{
        //    foreach (var item in GetAllEmployees())
        //    {
        //        if(item.FirstName.Contains(name))
        //        {

        //        }
        //    }
        //}

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public List<Role> GetAllRoles()
        {
            return roles;
        }

        public List<Department> GetAllDepartments()
        {
            return departments;
        }

        public List<Employee> GetAllDismissedEmployees()
        {
            return dismissedEmployees;
        }
    }
}
