using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using System.Configuration;
using System.Data.Common;

namespace DesignPatterns.EntityFramework
{
   

    public class SchoolDTO : DbContext
    {
        // SQL Connection String
        // Data Source=localhost; Initial Catalog=TestDB; Integrated Security=True; MultipleActiveResultSets=True;
        //nameOrConnectionString: "SchoolPostgreSQL"
        public SchoolDTO()
            : base("Data Source=localhost; Initial Catalog=TestDB; Integrated Security=True; MultipleActiveResultSets=True;")
        {
            // Turnoff DB Reset 
           // string test= ;
           // Database.SetInitializer<SchoolDTO>(null);
            Database.SetInitializer<SchoolDTO>(new DropCreateDatabaseIfModelChanges<SchoolDTO>());

          //  var factory = DbProviderFactories.GetFactory("Npgsql");
          //  var conn = factory.CreateConnection();
          //  conn.ConnectionString = ConfigurationManager.ConnectionStrings["SchoolPostgreSQL"].ToString();
          //  var npg = (NpgsqlConnection)conn;
          //  //var result = TestConnectionHelper(npg); // scalar select version(), nothing particular
          ////  Assert.AreEqual(result, "PostgreSQL 9.2.2, compiled by Visual C++ build 1600, 64-bit");            

             
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // PostgreSQL uses the public schema by default - not dbo.
        //    modelBuilder.HasDefaultSchema("public");
        //    base.OnModelCreating(modelBuilder);
        //}
        public DbSet<Student> SSLCStudents { get; set; }
        public DbSet<Standard> SSLC { get; set; }
    }
}
