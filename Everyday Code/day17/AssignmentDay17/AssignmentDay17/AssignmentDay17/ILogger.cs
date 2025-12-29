using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay17
{
    internal sealed class Logger
    {
        private Logger() { }
        private static Logger l = null;
        public static Logger GetInstance
        {
            get
            {
                if (l == null)
                {
                    l = new Logger();
                    return l;
                }
                else
                {
                    return l;
                }
            }
        }
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }
    }
}