using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
     class DatabaseApproach
    {
        public static void Main()
        {
            //GetAllEmpDetails();
            //storedprocedurewop();
            // storedprocedurewitpara();
            //updatedetail();
            CallStoredProcwithSQLParamater_insert();
        }

        //private static void GetAllEmpDetails()
        //{
        //    var ctx = new LearningContext();
        //    var emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();



        //    Console.WriteLine(emp.Ename + "  " + emp.Sal + "   " + emp.Job);
        //}


        //private static void storedprocedurewop()
        //{

        //    var ctx = new LearningContext();
        //    var EMP = ctx.Emps.FromSqlRaw("getallempdetails").ToList();


        //    foreach (var e in EMP)
        //    {
        //        Console.WriteLine(e.Ename);

        //    }

        //}

        //private static void storedprocedurewitpara()


        //{
        //  var ctx = new LearningContext();
        //var EMP = ctx.Emps.FromSqlRaw("getallempdetails @p0", 7654).ToList();

        //foreach (var a in EMP)
        //{
        //  Console.WriteLine(a.Ename);

        //}

        //        }
        //private static void updatedetail()
        //{
        //    var ctx = new LearningContext();
        //    try
        //    {
        //        var id = 7654;
        //        string name = "kushal";
        //        int employee = ctx.Database.ExecuteSqlRaw("updatenames @p0,@p1", id, name);
        //        Console.WriteLine(employee);
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        private static void CallStoredProcwithSQLParamater_insert()
        {
            var ctx = new LearningContext();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 1112
                        },

                         new SqlParameter() {
                            ParameterName = "@ename",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "indrajeet"},

                          new SqlParameter() {
                            ParameterName = "@sal",
                            SqlDbType =  System.Data.
                            SqlDbType.Decimal,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 1000
                          },


                          new SqlParameter() {
                            ParameterName = "@DEPTNO",
                            SqlDbType =  System.Data.
                            SqlDbType.Decimal,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 20
                          },



                       };

            try
            {
                var result = ctx.Database.ExecuteSqlRaw("adddemployee1 @empno, @ename ,@sal,@DEPTNO", param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {

                throw;
            }


            Console.WriteLine("update successful");

        }

    }
}
