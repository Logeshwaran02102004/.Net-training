using System;
using System.Linq;

namespace TrainingDay_2
{
    internal class EmployeeDetails
    {
        private string name;
        private int[] marks;
        

        public void StudentReport(int[] marks, string name)
        {
            this.marks = marks;
            this.name = name;
        }



        public void Calculate(out int total, out double average, out char grade)
        {
            total = marks.Sum();
            average = (double)total / marks.Length;
            if (average > 90)
                grade = 'A';
            else if (average > 80)
                grade = 'B';
            else if (average > 70)
                grade = 'C';
            else
                grade = 'D';
        }

        public void Display(int total, double average, char grade)
        {
            Console.WriteLine("=== Student Report ===");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Grade: {grade}");
        }
    }
}
