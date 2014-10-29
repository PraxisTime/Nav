using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EntityFramework
{
    //[Table("Standard")]  //, Schema = "public"
    public class Standard
    {
        public Standard()
        {

        }
        public int StandardId { get; set; }

        [Required(ErrorMessage = "Student Name is Required")]
        [Column("Name", TypeName = "ntext")]
        [MaxLength(20), MinLength(2, ErrorMessage = "Student name can not be 2 character or less")]
        public string StandardName { get; set; }
        public string Description { get; set; }
    }
}
