using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CSFeatures
    {
        public static void Main()
        {
            Action<string> action =(string name) => { Console.WriteLine($"hi {name}"); };

            Action<string,string> action1 = (string s1,string s2) => { Console.WriteLine($"hi {s1},"+$"you{s2}"); };

            Action<string, string, string> action2 = (string d1, string d2, string d3) => {
                Console.WriteLine(
                $"name{d1}", $"email{d2}", $"id{d3}");
            };
            action.Invoke("sujith");
            action1.Invoke("hey", "iam here");
            action2.Invoke("sujith", "mr.c.sujith@gmail.com", "2277");
        }

        
    }
}
