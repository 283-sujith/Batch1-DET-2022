using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public abstract  class animal
   
        {
            public int age { get; set; }
        public int name { get; set; }
        public int gender { get; set; }

        public abstract string makesounds();

 
    }
 }

