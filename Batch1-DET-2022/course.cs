using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class course
    {
        public string name { get; set; }
        public Student student{ get; set; }

        public string print()
        {
            return $"name={name}, Student={student.Print()}";
        }

    }
}
