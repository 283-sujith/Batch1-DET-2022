using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1Emp
{
    internal class Linq
    {
        private static void Main()
        {
            //the three parts of a linq query:deffered execution
            //1.data source.
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
                numbers.Add(4);

            //2.query creation.sql type
            var numQuery = from num in numbers //select num from numbers
                           select num;
            //query execution

            foreach(int num in numQuery)
            {
                Console.WriteLine("{0}",num);
                //num.Dump;//this is for linqpad not for vs
            }
            Console.ReadLine();
        }
    }
}
