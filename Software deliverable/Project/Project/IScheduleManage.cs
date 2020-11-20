using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    interface IScheduleManage
    {
        void FillWithSchedule(DataGridView dataGrid, int UserID);
    }
}
