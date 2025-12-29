using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoAssdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Connected connected = new Connected();
            //connected.DisplayAllcourses();
            //connected.Addnewstudent();
            //connected.SearchByDept();
            //connected.searchByStudentId();
            //connected.UpdateGrade();
            connected.procedure();


            //Disconnected disconnected = new Disconnected();
            //disconnected.Loadstucouindataset();
            //disconnected.UpdateCredits();
            //disconnected.InsertNewCourse();
            //disconnected.DeleteStudent();
        }
    }
}
