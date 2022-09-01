//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Batch1_DET_2022
//{
//    public class employeelinq
//    {

//        public employeelinq()
//        {

//        }

//        public employeelinq(int id, string name, string dept)
//        {
//            this.ID = id;
//            this.Name = name;
//            this.Dept = dept;

//        }
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public string Dept { get; set; }

//        public static void Main()
//        {
//            GetListofEmployees();
//        }


    //    public static List<Employee> GetListofEmployees()
    //    {
    //        List<Employee> emps = new List<Employee>();
    //        emps.Add(new employeelinq(1, "John", "Training"));
    //        emps.Add(new employeelinq(2, "Mark", "Finance"));
    //        emps.Add(new employeelinq(3, "Peter", "Technical"));
    //        emps.Add(new employeelinq(4, "Bob", "Technical"));
    //        emps.Add(new employeelinq(5, "Robert", "Finance"));
    //        emps.Add(new employeelinq(6, "Jason", "Training"));

    //        return emps;
    //    }

    //    private static void sampleemployeelist();
    //    {

    //       List<Employee> emps = GetListofEmployees();

    //    var emp_query = from employee in emps
    //                    select employee;

    //           foreach(var item in emp_query)
    //        {

    //          Console.WriteLine("Name is"+item.Name+"and dept is"+item.Dept);

    //        }
    //        Console.ReadLine();
    //    }

        
    //}


