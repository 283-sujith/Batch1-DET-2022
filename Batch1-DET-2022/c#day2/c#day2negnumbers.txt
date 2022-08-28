using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class negativenumbers
    {
        public static void Main()
        {
            int[] arr = { 10, -45, 2, 6, -54, -15 };
            int i, n;
            n = arr.Length;
            for (i = 1; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    Console.Write($"{arr[i]}");
                }

            }
        }
    }
}