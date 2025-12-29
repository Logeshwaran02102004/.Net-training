
using EmployeeServices;
using PayrollSystem;

namespace MainMethod
{
    public class Program
    {
        public static void Main()
        {
            IEmployeeDataReader reader = new MockEmployeeDataReader();
            PayrollProcessor processor = new PayrollProcessor(reader);

            Console.WriteLine("Comensation for 1 is : " + processor.CalculateTotalCompesation(101));
            Console.WriteLine("Comensation for 2 is " + processor.CalculateTotalCompesation(102));
            Console.WriteLine("Comensation for 3 is: " + processor.CalculateTotalCompesation(103));
        }
    }
}
