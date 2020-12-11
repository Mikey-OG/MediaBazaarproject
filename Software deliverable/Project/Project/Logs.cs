using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Logs
    {
        private string nameOfLog;
        private DateTime logDate;

        public Logs(string nameOfLog, DateTime logDate)
        {
            this.nameOfLog = nameOfLog;
            this.logDate = logDate;
        }

        public override string ToString()
        {
            return $"{nameOfLog} {logDate}";
        }
    }
}
