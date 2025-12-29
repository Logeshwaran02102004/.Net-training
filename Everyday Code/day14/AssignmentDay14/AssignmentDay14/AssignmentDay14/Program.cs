using System;
using System.Threading.Tasks;

namespace AssignmentDay14
{
    public class Program
    {
        private static void WriteLine(string msg) => Console.WriteLine(msg);

        public static async Task Main(string[] args)
        {
            School school = new School();

            await school.ShowAllStudents();

            ClassStudent s1 = await school.GetStudentAsync(2);
            WriteLine(s1.ToString());

            ClassStudent s2 = await school.GetStudentAsync(3);
            WriteLine(s2.ToString());

            ClassStudent s3 = await school.GetStudentAsync(99);
            WriteLine(s3.ToString());
        }
    }
}
