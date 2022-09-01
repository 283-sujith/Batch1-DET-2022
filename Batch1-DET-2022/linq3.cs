using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class linq3
    {
        public static void Main()
        {
            stringgroupby();

        }
        private static void stringgroupby()
        {
            List<string>words = new List<string>()
            { "basket","blueberry","chipanzee","abacus","banana","apple","cheese"};

            var wordgroups = words.GroupBy(x => x[0]).Select
                (y => new { firstletter = y.Key, words = y });

            foreach(var item in wordgroups)
            {
                Console.WriteLine("words that start with letter "+"letter '{0}':",item.firstletter);
                
                foreach(var  w in item.words)
                {
                    Console.WriteLine(w);
                }
            }

        }
    }
}
