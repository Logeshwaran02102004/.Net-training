using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismdemo
{
    public class Assignment3day8
    {
        public void Logmessage(string message)
        {
            Console.WriteLine("the message is : " + message);
        }
        public void Logmessage(string message ,int level)
        {
            Console.WriteLine($"the message is {message} and level is{level}");
        }
        public void Logmessage(string message,string time)
        {
            Console.WriteLine("the message and time is :" + message, time);
        }
        public void Logmessage(string message, int level, string time)
        {
            Console.WriteLine("the message,level,datetime"+message, level, time);
        }
    }
}
