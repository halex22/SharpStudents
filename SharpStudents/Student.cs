using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpStudents
{
    internal class Student
    {
        private List<int> _marks = []; 
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public string Gender { get; set; }
        public int Yob { get; set; }
        public List<int> Marks {
            get => _marks;
            set => _marks = value ?? [];
        }

        public double Mean => _marks.Count == 0 ? 0 : _marks.Average();

        public string ToString() => $"student name: {Name} {Surname}\nYear of Birth: {Yob}";

    }
}
