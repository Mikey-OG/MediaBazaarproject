using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.DAL;

namespace Project.LGC
{
    public class RoleManagementClass: IObjectList
    {
        private List<Role> roles;
        private RoleManagementDAL rmd;
        private List<string> formAccesses;

        public RoleManagementClass()
        {
            roles = new List<Role>();
            rmd = new RoleManagementDAL();
            formAccesses = new List<string>();       
        }

        public void InitializeListOfClasses()
        {
            rmd.AddToDtbListOfRoles();
            foreach (var item in rmd.GetListOfAllRolesFromDatabase())
            {
                roles.Add(item);
            }
        }

        public void AddAllFormAccess()
        {
            rmd.AddAllFormAccessFromDtb();
            foreach (var item in rmd.GetAllFormAccessInDtb())
            {
                formAccesses.Add(item);
            }
        }

        //Adding department logic
        public bool RoleDoesNotExistInList()
        {
            foreach (var item in rmd.GetListOfAllRolesFromDatabase())
            {
                if (!roles.Contains(item))
                {
                    roles.Add(item);
                    return true;
                }
            }
            return false;
        }

        public bool AddRole(Role role)
        {
            //if the data has been added into the database 
            if (rmd.AddRoleToDatabase(role) == true)
            {
                rmd.AddToDtbListOfRoles();
                //add that department into the list of departments
                if (RoleDoesNotExistInList() == true)
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

        //Removing role logic
        public bool RemoveFoundRole()
        {
            //go through the list of departments
            foreach (var item in roles)
            {
                if (!rmd.GetListOfAllRolesFromDatabase().Contains(item))
                {
                    roles.Remove(item);
                    return true;
                }
            }
            return false;
        }

        public bool RemoveRole(int id)
        {
            //if the data has been removed from the database 
            if (rmd.RemoveRoleFromDatabase(id) == true)
            {
                rmd.RemoveFromDtbListOfRoles(id);
                //remove the found department from the list 
                if (RemoveFoundRole() == true)
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

        //Update role logic 
        public bool UpdateRole(Role role)
        {
            //if the role is updated in the database 
            if (rmd.UpdateRoleInDatabase(role) == true)
            {
                //update the database list of roles 
                //my reason for not updating the current list we have is because 
                //all objects stored in this current list called roles are instances of the dtbrolelist
                if (rmd.UpdateInDtbListOfRoles(role) == true)
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


        public List<Role> GetAllRoles()
        {
            return roles;
        }

        public List<string> GetAllFormAccess()
        {
            return formAccesses;
        }
    }
}
