using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class linq
    {
        private static void Main()
        {
            //the three parts of a linq query:deffered execution
            //1.data source.
            List<int> numbers = new List<int>();
            numbers.Add(111);
            numbers.Add(100);
            numbers.Add(105);
            numbers.Add(102);

            //2.query creation.sql type

            //ex for deffered execution
             var numQuery = from num in numbers //select num from numbers
                          select num;
            //early execution
            //var numQuery = from num in numbers //select num from numbers
            //               where num>100
            //               select num;
            //numbers.Add(6);
            //lamda ex
            // var numQuery = numbers.Select(x => x);
            //var numQuery = numbers.Where(x=>x>102);
            //query execution

            foreach (int num in numQuery)
            {
                Console.WriteLine("{0}", num);
                //num.Dump;//this is for linqpad not for vs
            }
            Console.ReadLine();
        }
    }
}
