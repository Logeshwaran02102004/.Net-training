using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectedDemo connectedDemo = new ConnectedDemo();
            //connectedDemo.ShowEmployee();
            //connectedDemo.AddEmployee();
            //connectedDemo.UpdateEmployee();
            //connectedDemo.DeleteEmployee(13);
            //connectedDemo.Showprocedure();
            connectedDemo.EmpTransaction();


        }
    }
}
