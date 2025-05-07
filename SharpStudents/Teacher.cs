using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SharpStudents
{
    internal class Teacher
    {
        List<Student> _students;
        public required string Name { get; set; }
        public required string Subject { get; set; }
        public List<Student> Students {
            get => _students ; 
            set => _students = value ?? [];
        }
        public double studentsMean => _students.Average(s => s.Mean);

        public string ToString()
        {
            string allStudentsString = Students.Aggregate("", (total, next) => total += ("\t" + next.ToString() + "\n"));
            return $"teacher {Name} of subject {Subject} has this students:\n{allStudentsString}";
        }
    }
}
