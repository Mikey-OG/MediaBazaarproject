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
        private int logID;

        public Logs(string nameOfLog, DateTime logDate)
        {
            this.nameOfLog = nameOfLog;
            this.logDate = logDate;
        }

        public string NameOfLog
        {
            get
            {
                return nameOfLog;
            }
        }
        public override string ToString()
        {
            return $"{nameOfLog} {logDate}";
        }
    }
}
