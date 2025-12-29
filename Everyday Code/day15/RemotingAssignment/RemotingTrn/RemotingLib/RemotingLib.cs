using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RemoteTrn;

namespace RemoteLib
{
    public class StudentService : MarshalByRefObject, IStudentService
    {
        // Dictionary initializer (use full constructor)
        private Dictionary<int, ClassStudent> students = new Dictionary<int, ClassStudent>
        {
            {1, new ClassStudent { Name = "Logesh", Class = "10th", TotalMarks = 481, Gender = 'M' }},
            {2, new ClassStudent { Name = "Prathees", Class = "12th", TotalMarks = 570, Gender = 'M' }},
            {3, new ClassStudent { Name = "Waseef", Class = "11th", TotalMarks = 550, Gender = 'M' }}
        };

        private void WriteLine(string msg) => Console.WriteLine(msg);

        public async Task ShowAllStudents()
        {
            try
            {
                foreach (var student in students.Values)
                    WriteLine(student.ToString());
            }
            catch (Exception ex)
            {
                await Task.Delay(100);
                WriteLine($"Error in ShowAllStudents: {ex.Message}");
            }
        }

        public async Task<ClassStudent> GetStudentAsync(int id)
        {
            try
            {
                await Task.Delay(200);

                if (!students.ContainsKey(id))
                {
                    return new ClassStudent
                    {
                        Name = "Default Student",
                        Class = "N/A",
                        TotalMarks = 0,
                        Gender = 'N'
                    };
                }

                ClassStudent s = students[id];

                if (s.TotalMarks < 300)
                    throw new Exception("Total marks are less than 300");

                return s;
            }
            catch (Exception ex) when (ex.Message.Contains("less than 300"))
            {
                await Task.Delay(100);
                WriteLine($"Handled Exception: {ex.Message}");

                return new ClassStudent
                {
                    Name = "Error Student",
                    Class = "N/A",
                    TotalMarks = 0,
                    Gender = 'X'
                };
            }
            catch (Exception ex)
            {
                await Task.Delay(100);
                WriteLine($"Unexpected Error: {ex.Message}");

                return new ClassStudent
                {
                    Name = "Error Student",
                    Class = "N/A",
                    TotalMarks = 0,
                    Gender = 'X'
                };
            }
        }
    }
}
