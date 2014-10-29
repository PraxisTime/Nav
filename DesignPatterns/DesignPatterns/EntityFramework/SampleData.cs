using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EntityFramework
{
    public class SampleData : DropCreateDatabaseIfModelChanges<SchoolDTO>
    {
        protected override void Seed(SchoolDTO ctx)
        {
            ctx.SSLCStudents.Add(new Student() { StudentName = "Mahesh", Standard = new Standard() { StandardName = "SSLC" } });
            ctx.SSLCStudents.Add(new Student() { StudentName = "Jagadish", Standard = new Standard() { StandardName = "PUC" } });
            ctx.SSLCStudents.Add(new Student() { StudentName = "Sharma", Standard = new Standard() { StandardName = "BE" } });
            ctx.SaveChanges();
        }
    }
}
