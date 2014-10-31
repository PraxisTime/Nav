using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EntityFramework
{

    [Table("Student" )] //
    public class Student
    {
        //public Student()
        //{

        //}

        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Column("studentid")]
        public int StudentID { get; set; }

        [Column("studentname")]
        public string StudentName { get; set; }
        [Column("Gender")]
        public string Gender { get; set; }
        // [Column("stdid")]
        //public int StdId { get; set; }

        //[ForeignKey("StdId")]
        //public virtual Standard Standard { get; set; }
    }
}
