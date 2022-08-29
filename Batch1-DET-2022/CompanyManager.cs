using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class CompanyManager
    {
        public string name {  get; set; }
        public string surname { get; set; }
        public string phone { get; set; }

        public string print()
        {
            return $"name={name},surname={surname},phone={phone}";
        }

    }
}
