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
        private string logDate;

        public Logs(string nameOfLog, string logDate)
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
        public string LogDate
        {
            get
            {
                return logDate;
            }
        }
        public override string ToString()
        {
            return $"{nameOfLog} {logDate}";
        }
    }
}
