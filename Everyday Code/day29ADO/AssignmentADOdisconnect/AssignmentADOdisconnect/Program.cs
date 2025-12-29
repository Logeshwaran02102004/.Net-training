using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADOdisconnect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Disconnect disconnect = new Disconnect();
            //disconnect.showemployeeanddept();
            //disconnect.SortingtheEmployee();
            //disconnect.NumberofTables();
            //disconnect.DepartmentTableLoader();
            disconnect.MergingDataSets();
            disconnect.ReadXMLDataSource();
        }
    }
}
