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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Yob { get; set; }
        public List<int>? Marks {
            get => _marks;
            set => _marks = value;
        }

        public void ToString() { }

        public double CalcolateMean()
        {
            return this._marks.Sum() / (double) this._marks.Count;
        }

        

    }
}
