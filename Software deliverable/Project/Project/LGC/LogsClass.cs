using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL;

namespace Project.LGC
{
    class LogsClass
    {
        private LogsDAL ld;
        private List<Logs> allLogs;

        public LogsClass()
        {
            ld = new LogsDAL();
            allLogs = new List<Logs>();
        }

        public void AddAllLogs()
        {
            ld.AddToDtbListOfLogs();
            foreach (var item in ld.GetAllLogsFromDtb())
            {
                allLogs.Add(item);
            }
        }
        public bool LogDoesNotExistInList()
        {
            foreach (var item in ld.GetAllLogsFromDtb())
            {
                if (!allLogs.Contains(item))
                {
                    allLogs.Add(item);
                    return true;
                }
            }
            return false;
        }

        public bool AddNewEmployeeLog(Employee employee)
        {
            if (ld.NewEmployeeLog(employee) == true)
            {
                ld.AddToDtbListOfLogs();
                if (LogDoesNotExistInList() == true)
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

        public bool AddNewEmployeeUpdateLog(Employee employee)
        {
            if (ld.EmployeeUpdateLog(employee) == true)
            {
                ld.AddToDtbListOfLogs();
                if (LogDoesNotExistInList() == true)
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

        public bool AddNewEmployeeDismmisalLog(Employee employee)
        {
            if (ld.EmployeeDismissalLog(employee) == true)
            {
                ld.AddToDtbListOfLogs();
                if (LogDoesNotExistInList() == true)
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

        //Roles logs
        public bool AddNewRoleLog(Role role)
        {
            if (ld.NewRolesLog(role) == true)
            {
                ld.AddToDtbListOfLogs();
                if (LogDoesNotExistInList() == true)
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

        public bool AddNewRoleUpdateLog(Role role)
        {
            if (ld.RoleUpdateLog(role) == true)
            {
                ld.AddToDtbListOfLogs();
                if (LogDoesNotExistInList() == true)
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

        public bool AddNewRoleRemoveLog(Role role)
        {
            if (ld.RoleRemovelLog(role.RoleName) == true)
            {
                ld.AddToDtbListOfLogs();
                if (LogDoesNotExistInList() == true)
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



        //Department logs
        public bool AddNewDepartmentLog(Department department)
        {
            if (ld.NewDepartmentLog(department) == true)
            {
                ld.AddToDtbListOfLogs();
                if (LogDoesNotExistInList() == true)
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

        public bool AddNewDepartmentUpdateLog(Department department)
        {
            if (ld.DepartmentUpdateLog(department) == true)
            {
                ld.AddToDtbListOfLogs();
                if (LogDoesNotExistInList() == true)
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

        public bool AddNewDepartmentRemoveLog(Department department)
        {
            if (ld.DepartmentUpdateLog(department) == true)
            {
                ld.AddToDtbListOfLogs();
                if (LogDoesNotExistInList() == true)
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
        public List<Logs> GetAllLogs()
        {
            return allLogs;
        }
    }
}
