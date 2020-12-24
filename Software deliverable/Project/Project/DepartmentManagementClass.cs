using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    public class DepartmentManagementClass
    {
        List<Department> departments;
        DepartmentManager dm = new DepartmentManager();

        public DepartmentManagementClass()
        {     
            departments = new List<Department>();
        }

        public bool AddDepartment(Department department)
        {     
            return true;
        }

        //    public bool RemoveDepartment(int id)
        //    {
        //        foreach (var item in departments)
        //        {
        //            if (item.ID == id)
        //            {
        //                dm.RemoveDepartmentFromDatabase(id);
        //                departments.Remove(item);
        //                return true;
        //            }
        //        }
        //        return false;
        //    }


        //    public bool DepartmentRemoveMessageBoxYesNo()
        //    {
        //        DialogResult dialog = MessageBox.Show("Are you sure you want to remomve this department",
        //         "Remove department", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //        if (dialog == DialogResult.Yes)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            if (dialog == DialogResult.No)
        //            {
        //                return false;
        //            }
        //        }
        //        return false;    
        //    }

        //public List<Department> GetAllDepartments()
        //{
        //    departments.Add(dm.GetAllDepartmentsFromDatabase());
        //    return departments;
        //}
    }
}
