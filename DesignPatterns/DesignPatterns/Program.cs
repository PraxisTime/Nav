using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC5Demo.DTO;
using DesignPatterns.EntityFramework;
using System.Data.Entity;
using Npgsql;
using System.Data;

namespace DoFactory.GangOfFour.Adapter.Structural
{

    //namespace InterfaceExamples
    //{
    //    interface IVehicle
    //    {
    //        string Message { get; }
    //    }
    //    interface ICart
    //    {
    //        string Message { get; }
    //    }
    //    class Vehicle : IVehicle, ICart
    //    {
    //        string IVehicle.Message
    //        {
    //            get
    //            {
    //                return "It is a Vehicle Interface Message";
    //            }
    //        }
    //        string ICart.Message
    //        {
    //            get
    //            {
    //                return "It is a Cart Interface Message";
    //            }
    //        }

    //        public string Message
    //        {
    //            get
    //            {
    //                return "It Is local";
    //            }
    //        }
    //    }
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            IVehicle vehicle = new Vehicle();
    //            Console.WriteLine("Message is : {0}", vehicle.Message);
    //            ICart cart = new Vehicle();
    //            Console.WriteLine("Message is : {0}",((Vehicle) cart).Message);
    //            Vehicle vh = new Vehicle();
    //            Console.WriteLine("Message is : {0}", ((ICart)vh).Message);
    //            Console.Read();
    //        }
    //    }
    //}

    //namespace AbstractClassExamples
    //{


    //    interface IVehicle
    //    {
    //        void Message2();
    //        void Message();
    //    }


    //    abstract class AVehicle
    //    {
    //        public abstract void Message();
    //        public  void Message1()
    //        {
    //            Console.WriteLine("Abstract Implemented Abstract Class");
    //        }

    //        public  virtual void Message2()
    //        {
    //            Console.WriteLine("Abstract virtual Implemented Abstract Class");
    //        }
           
    //    }
        

    //    class Vehicle : AVehicle
    //    {
    //        public override void Message()
    //        {
    //            Console.WriteLine("Base Override");
    //        }

    //        public new void Message1()
    //        {
    //            Console.WriteLine("Base New message1");
    //        }

    //        public override  void Message2()
    //        {
    //            Console.WriteLine("Base New message2");
    //        }
            
    //    }

#region DTO
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        string choice = string.Empty, dbProvider = string.Empty;
    //        bool done = false;
    //        do
    //        {
    //            Console.Clear();
    //            Console.WriteLine("\t Select one of the Database Providers \n");
    //            Console.WriteLine("\t 1. POSTGRES SQL");
    //            Console.WriteLine("\t 2. MSSQL");
    //            Console.WriteLine("===============================================");
    //            Console.Write("\t Enter Your Selection (0 to exit) : ");
    //            choice = Console.ReadLine();

    //            switch (choice)
    //            {
    //                case "0":
    //                    done = true;
    //                    break;
    //                case "1":
    //                    dbProvider = "Postgres";
    //                    break;
    //                case "2":
    //                    dbProvider = "mssql";
    //                    break;
    //            }
    //            if (choice != "0")
    //            {
    //                Console.WriteLine("===========================================");
    //                DTOFactory Factory = new DbDTO();
    //                var DAL = Factory.GetDataAccessLayer((DataProviderType)Enum.Parse(typeof(DataProviderType), dbProvider));
    //                Console.WriteLine(DAL.OpenConnection());
    //                Console.ReadKey();
    //            }
    //        } while (!done);
    //    }
    //}
#endregion
    //    //}

    #region Multi Tennent
    class Program
    {
        
        static void Main(string[] args)
        {

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {                 
               // var ctx1 = new SchoolDTO();
               //// ctx1.Database.Connection.Open();

                //string sql = "SELECT * FROM simple_table";
                //// data adapter making request from our connection

                //NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=Test;User Id=postgres;Password=s@1;");

                //NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
                //// i always reset DataSet before i do
                //// something with it.... i don't know why :-)
                //ds.Reset();
                //// filling DataSet with result from NpgsqlDataAdapter
                //da.Fill(ds);
                //// since it C# DataSet can handle multiple tables, we will select first
                //dt = ds.Tables[0];


              //  ctx1.Database.Connection.Close();
                using (var ctx = new SchoolDTO())
                {
                  //  ctx.Database.Connection.Open();
                    ctx.SSLCStudents.Add(new Student() { StudentName = "Mahesh" });
                    ctx.SSLCStudents.Add(new Student() { StudentName = "Suresh" });
                    ctx.SSLCStudents.Add(new Student() { StudentName = "Rajesh" });
                    //ctx.SSLCStudents.Add(new Student() { StudentName = "Jagadish", Standard = new Standard() { StandardName = "PUC" } });
                    //ctx.SSLCStudents.Add(new Student() { StudentName = "Sharma", Standard = new Standard() { StandardName = "BE" } });
                    ctx.SaveChanges();
                }
                Console.WriteLine("Completed");
                Console.ReadLine();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Console.ReadLine();
            }

        }

    }
    #endregion




    
    
}
 
