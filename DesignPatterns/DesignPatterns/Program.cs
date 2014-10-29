using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC5Demo.DTO;
using DesignPatterns.EntityFramework;
using System.Data.Entity;

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

    namespace AbstractClassExamples
    {


        interface IVehicle
        {
            void Message2();
            void Message();
        }


        abstract class AVehicle
        {
            public abstract void Message();
            public  void Message1()
            {
                Console.WriteLine("Abstract Implemented Abstract Class");
            }

            public  virtual void Message2()
            {
                Console.WriteLine("Abstract virtual Implemented Abstract Class");
            }
           
        }
        

        class Vehicle : AVehicle
        {
            public override void Message()
            {
                Console.WriteLine("Base Override");
            }

            public new void Message1()
            {
                Console.WriteLine("Base New message1");
            }

            public override  void Message2()
            {
                Console.WriteLine("Base New message2");
            }
            
        }

        //DTO MAIN
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
        //            Console.WriteLine("\t 1. Access / OleDb");
        //            Console.WriteLine("\t 2. Odbc");
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

        class Program
        {
            static void Main(string[] args)
            {
                try
                {

                    
                    using (var ctx = new SchoolDTO())
                    {

                        ctx.SSLCStudents.Add(new Student() { StudentName = "Mahesh", Standard = new Standard() { StandardName = "SSLC" } });
                        ctx.SSLCStudents.Add(new Student() { StudentName = "Jagadish", Standard = new Standard() { StandardName = "PUC" } });
                        ctx.SSLCStudents.Add(new Student() { StudentName = "Sharma", Standard = new Standard() { StandardName = "BE" } });
                        ctx.SaveChanges();
                    }
                    Console.WriteLine("Completed");
                    Console.ReadLine();
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                    Console.ReadLine();
                }
                
            }

        }
    }
}
 
