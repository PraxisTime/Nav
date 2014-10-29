using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EntityFramework
{

    //[Table("StudentInfo")] //,Schema="public"
    public class Student
    {
        public Student()
        {

        }

        [Key]
        public int StudentID { get; set; }
                
        public string StudentName { get; set; }

        public string Gender { get; set; }

        public int StdId { get; set; }

        [ForeignKey("StdId")]
        public virtual Standard Standard { get; set; }
    }
}
