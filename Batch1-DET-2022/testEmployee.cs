using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class testEmployee
    {
        public static void Main()
        {
            Employee emp = new Employee(22777, "sujith", "blore", 560098, 8105095436,33500);
            Console.WriteLine($"Employee sal{emp.GetEmpnetsalary()}");
            Console.WriteLine($"eMPLOYEE GRADE IS{emp.GetEmpgrade()}");

        }
    }
}
