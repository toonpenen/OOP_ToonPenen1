using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ToonPenen1.Models
{
    public static class LoggerService
    {
        private static LogMessage[] logs;

        public static LogMessage[] Logs
        {
            get { return logs; }
            set { logs = value; }
        }
        static LoggerService()
        {
            logs = new LogMessage[0];
        }
        public static void AddLogMessage(LogMessage message)
        {
            int newSize = Logs.Length + 1;
            Array.Resize(ref logs, newSize);
            Logs[Logs.Length - 1] = message;
        }

    }
}
