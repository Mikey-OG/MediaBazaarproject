using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project.DAL;

namespace Project.LGC
{
    public class DepartmentManagementClass: IObjectList
    {
        private DepartmentManagementDAL dmd;
        private List<Department> departments;

        public DepartmentManagementClass()
        {
            dmd = new DepartmentManagementDAL();
            departments = new List<Department>();
        }

        public void InitializeListOfClasses()
        {
            dmd.AddToDtbListOfDepartments();
            foreach (var item in dmd.GetListOfAllDepartmentsFromDatabase())
            {
                departments.Add(item);
            }
        }

        //Adding department logic
        public bool DepartmentDoesNotExistInList()
        {
            foreach (var item in dmd.GetListOfAllDepartmentsFromDatabase())
            {
                if (!departments.Contains(item))
                {
                    departments.Add(item);
                    return true;
                }
            }
            return false;
        }

        public bool AddDepartment(Department department)
        {
            //if the data has been added into the database 
            if (dmd.AddDepartmentToDatabase(department) == true)
            {
                dmd.AddToDtbListOfDepartments();
                //add that department into the list of departments
                if (DepartmentDoesNotExistInList() == true)
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


        //Removing department logic
        public bool RemoveFoundDepartment()
        {
            //go through the list of departments
            foreach (var item in departments)
            {
                if (!dmd.GetListOfAllDepartmentsFromDatabase().Contains(item))
                {
                    departments.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public bool RemoveDepartment(int id)
        {
            //if the data has been removed from the database 
            if (dmd.RemoveDepartmentFromDatabase(id) == true)
            {
                dmd.RemoveFromDtbListOfDepartments(id);
                //remove the found department from the list 
                if (RemoveFoundDepartment() == true)
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


        //Update department logic 
        public bool UpdateDepartment(Department department)
        {
            //if the department is updated in the database 
            if (dmd.UpdateDepartmentInDatabase(department) == true)
            {
                //update the database list of departments 
                //my reason for not updating the current list we have is because 
                //all objects stored in this current list called departments are instances of the dtbdepartmentlist
                if (dmd.UpdateInDtbListOfDepartments(department) == true)
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

        public List<Department> GetAllDepartments()
        {
            return departments;
        }
    }
}
