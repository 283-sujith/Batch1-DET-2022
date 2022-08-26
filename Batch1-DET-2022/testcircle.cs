using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class testcircle
    {
        public static void Main()
        {
            circle c = new circle(10);
            Console.WriteLine($"area{c.Getarea()} cm");
            
        }
    }
}
