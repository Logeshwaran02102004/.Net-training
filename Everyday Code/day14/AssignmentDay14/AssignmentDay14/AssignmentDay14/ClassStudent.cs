using System;

namespace AssignmentDay14
{
    internal class ClassStudent
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public int TotalMarks { get; set; }
        public char Gender { get; set; }

        public override string ToString()
            => $"{Name}, Class: {Class}, Total Marks: {TotalMarks}";
    }
}
