using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Batch1_DET_2022.manager;

namespace Batch1_DET_2022
{
    class PROGRAMNEW
    {


        //using Batch1_DET_2022;

        public static void Main()
        {
            try
            {
                Empp m = new Manager(4671, "Karthika", new DateTime(2005, 5, 10), "techtrng", 10);  //default constructor
                                                                                                    // Console.WriteLine(m.Print());

                Empp m1 = new Manager(2345, "Jeeva", new DateTime(2010, 1, 14), "PEMS", 450);
                // Console.WriteLine(m1.Print());  //base class ref can point to derived object

                Empp e1 = new Empp(1, "Jiyana", new DateTime(2020, 1, 5));
                //Console.WriteLine(e1.Print());

                Console.WriteLine("enter empid b.w 1001 - 25000");
                int id = Convert.ToInt32(Console.ReadLine());
                if (id < 1001 || id > 25000)
                    throw new InvalidEmpIDException("Entered empid is not in the range...");

                Console.WriteLine("enter emp name");
                string name = Console.ReadLine();

                Console.WriteLine("enter doj");
                DateTime doj = DateTime.Parse(Console.ReadLine());

                Empp e2 = new(id, name, doj);


                List<Empp> list = new List<Empp>();
                list.Add(m);
                list.Add(m1);
                list.Add(e1);
                foreach (Empp x in list)
                    Console.WriteLine(x.Print());
            }
            catch (InvalidEmpIDException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            { }


        }
    }
}
