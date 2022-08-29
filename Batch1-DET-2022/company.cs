using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class company
    {
        public string name { get; set; }
        public string addres { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public CompanyManager  manager { get; set; }

        public string print()
        {
            return $"name={name},addres={addres},phone={phone},website={website},manager={manager.print()}";
        }
    }
}
