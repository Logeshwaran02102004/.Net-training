using System;
using System.Threading.Tasks;

namespace RemoteTrn
{
    public interface IStudentService
    {
        Task ShowAllStudents();
        Task<ClassStudent> GetStudentAsync(int id);
    }

    public class ClassStudent
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int TotalMarks { get; set; }
        public char Gender { get; set; }

        public override string ToString()
            => $"{Name}, Class: {Class}, Total Marks: {TotalMarks}";
    }
}
