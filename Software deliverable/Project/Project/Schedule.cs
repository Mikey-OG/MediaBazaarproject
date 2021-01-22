using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Schedule
    {
        private int userId;
        private string date;
        private string shift;

        public Schedule(int userId, string date, string shift)
        {
            this.userId = userId;
            this.date = date;
            this.shift = shift;
        }

        public int UserId
        {
            get
            {
                return userId;
            }
        }

        public string Date
        {
            get
            {
                return date;
            }
        }

        public string Shift
        {
            get
            {
                return shift;
            }
        }
    }
}
