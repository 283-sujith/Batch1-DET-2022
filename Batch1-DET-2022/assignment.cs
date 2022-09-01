using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class assignment
    {
        public static void Main()
        {
            assignment1();
            assignment2();
            assignment3();



        }

        private static void assignment1()
        {
            List<string> names = new List<string>();
            names.Add("jhon");
            names.Add("peter");
            names.Add("jacob");
            names.Add("harry");
            names.Add("jackson");


            // var numQuery = from o in names //select num from numbers
            //              where names = o
            //         select names;

            var result = names.Where(word => word.Contains('o'));

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }

        }
        private static void assignment2()
        {
            // In a array of names, find the names which has max no of character length
            List<string> names = new List<string>();
            names.Add("jhon");
            names.Add("peter");
            names.Add("jacob");
            names.Add("harry");
            names.Add("jackson");

           // var result =Max();
            var result = from word in names select word;
            //names.Where(word => word.Contains('o'));
            foreach (var word in result)
                Console.WriteLine($"{word}-{word.Length}");
        }
        private static void assignment3()
        {

            List<string> names = new List<string>();
            names.Add("believe");
            names.Add("relief");
            names.Add("receipt");
            names.Add("field");


            var result = from word in names select word;
            //names.Where(word => word.Contains('o'));
            foreach (var word in result)
                Console.WriteLine($"{word}-{word.Length}");


        }

    }
}