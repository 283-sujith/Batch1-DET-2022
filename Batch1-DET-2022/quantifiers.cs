using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class quantifiers
    {
        public static void Main()
        {
            quantifiers1();
            quantifiers2();
            quantifiers3();
        }

        private static void quantifiers1()
        {
            string[] names = { "sujith", "suhas", "sushal", "sishal" };

            var result = names.All(n => n.StartsWith("s"));

            Console.WriteLine("Does all of the names start with the letter 's':");
            Console.WriteLine(result);
        }
        private static void quantifiers2()
        {
            string[] names = { "toy", "Ned", "Amy", "chill" };

            var result = names.Any(n => n.StartsWith("c"));

            Console.WriteLine("Does any of the names start with the letter 'B':");
            Console.WriteLine(result);
        
        }
        private static void quantifiers3()
        {
            int[] numbers = { 1, 3, 5, 7, 9 };

            var result = numbers.Contains(5);

            Console.WriteLine("sequence contains the value 5:");
            Console.WriteLine(result);

        }
    }
}
