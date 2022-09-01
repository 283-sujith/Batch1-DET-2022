using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LiNq1
    {

        private static void Main()
        {

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = numbers.TakeWhile(n => n < 5);

            Debug.WriteLine("takes numbers until the condition is met:");
            foreach (int number in result)
                Debug.WriteLine(number);




            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = numbers.Take(7);

            //Debug.WriteLine("only 5 numbers is taken:");
            //foreach (int number in result)
            //    Debug.WriteLine(number);





            //string[] words = { "one", "two", "three", "four", "five", "six" };

            //var result = words.SkipWhile(w => w.Length == 3);

            //Debug.WriteLine("it skips wen the condition is met:");
            //foreach (string word in result)
            //    Debug.WriteLine(word);





            //string[] words = { "one", "two", "three", "four", "five", "six" };

            //var result = words.Skip(4);

            //Debug.WriteLine("first 4 words is skipped:");
            //foreach (string word in result)
            //    Debug.WriteLine(word);




            //string[] names = { "kiran", "sujith", "" };

            //var result = names.OrderByDescending(n => n);

            //Debug.WriteLine("Descending ordered list of names:");
            //foreach (string name in result)
            //    Debug.WriteLine(name);


            //    Car[] cars =
            //    {
            //        new Car { Name = "Super Car", HorsePower = 215 },
            //        new Car { Name = "Economy Car", HorsePower = 75 },
            //        new Car { Name = "Family Car", HorsePower = 145 },
            //    };
            //    var result = cars.OrderBy(c => c.HorsePower);

            //    Debug.WriteLine("Ordered list of cars by horsepower:");
            //    foreach (Car car in result)
            //        Debug.WriteLine(String.Format("{0}: {1} horses", car.Name, car.HorsePower));
            //}
            //    {
            //        var dates = new DateTime[] {
            //    new DateTime(2015, 2, 15),
            //    new DateTime(2015, 3, 25),
            //    new DateTime(2015, 1, 5)
            //};

            //        var result = dates.OrderBy(d => d);

            //        Debug.WriteLine("Ordered list of dates:");
            //        foreach (DateTime dt in result)
            //            Debug.WriteLine(dt.ToString("yyyy/MM/dd"));

            //int[] numbers = { 7, 9, 5 };

            //var result = numbers.OrderBy(n => n);

            //Debug.WriteLine("Ordered list of numbers:");
            //foreach (int number in result)
            //    Debug.WriteLine(number);


            //List<int> numbers = new List<int>();
            //numbers.Add(0);
            //numbers.Add(1);
            //numbers.Add(20);
            //numbers.Add(3);
            //numbers.Add(400);
            //numbers.Add(5);
            //numbers.Add(600);


            ////var numQuery = from num in numbers
            //            //  select num;

            //var numQuery = from num in numbers 
            //            where num<100
            //               select num;

            foreach (int name in result)
            {
                Console.WriteLine("{0}", name);
            }
            Console.ReadLine();

        }
    }
}



