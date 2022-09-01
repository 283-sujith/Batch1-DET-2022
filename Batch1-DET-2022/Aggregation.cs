using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    class Aggregation
    {
        public static void Main()
        {
            //aggreation1();
            //aggreation2();
            aggreation3();
            //aggreation4();
            //aggreation5();
            //aggreation6();
            //aggreation7();
            ////aggreation8();
        }

        //private static void aggreation1()
        //{
        //    var numbers = new int[] { 1, 2, 3, 4, 5 };

        //    var result = numbers.Aggregate((a, b) => a * b);

        //    Console.WriteLine("multiplication:");
        //    Console.WriteLine(result);
        //}
        //private static void aggreation2()
        //{
        //    var numbers = new int[] { 1, 2, 3 };

        //    var result = numbers.Aggregate(10, (a, b) => a + b);

        //    Console.WriteLine("with a seed of 10:");
        //    Console.WriteLine(result);
        //}

        private static void aggreation3()
        {
            int[] numbers = { 10, 10, 11, 11 };

            var result = numbers.Average();

            Console.WriteLine("Average:");
            Console.WriteLine(result);
        }
        //private static void aggreation4()
        //{
        //    string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

        //    var result = names.Count();

        //    Console.WriteLine("Counted names are:");
        //    Console.WriteLine(result);
        //}

        private static void aggreation5()
        {
            var largeArr = Enumerable.Range(0, Int32.MaxValue).Concat(Enumerable.Range(0, 5));

            Int64 result = largeArr.LongCount();

            Console.WriteLine("Counting large Array elements:");
            Console.WriteLine(result);
        }

        //private static void aggreation6()
        //{
        //    int[] numbers = { 2, 8, 5, 6, 1 };

        //    var result = numbers.Max();

        //    Console.WriteLine(" the highest number is:");
        //    Console.WriteLine(result);

        //}
        //private static void aggreation7()
        //{
        //    int[] numbers = { 6, 9, 3, 7, 5 };

        //    var result = numbers.Min();

        //   Console.WriteLine(" the lowest number is:");
        //    Console.WriteLine(result);
        //}

        //private static void aggreation8()
        //{
        //    int[] numbers = { 2, 5, 10 };

        //    var result = numbers.Sum();

        //    Console.WriteLine("summing the numbers:");
        //    Console.WriteLine(result);

        //}

        }

    }

