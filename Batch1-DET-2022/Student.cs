//Crate a base class to take regno and name of students. Using inheritance, write a program that will take marks as input from the student. Provide two branches science and commerce. If the student enters science, then get the marks of physics, chemistry, and math. If the student enters commerce, get the marks for economics, accounts, and banking. Then calculate the average of the three subjects. The output should display regno, name, details of marks subject wise and the average of marks.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Batch1_DET_2022
{
    public abstract class Student
    {
        public int regno { get; set; }
        public string Name { get; set; }



        public abstract double GetAvgMarks();

        internal object Print()
        {
            throw new NotImplementedException();
        }
    }
}

