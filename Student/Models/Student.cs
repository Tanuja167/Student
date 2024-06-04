using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student.Models
{

    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        public int Percentage { set; get; }
        [Required]
        public string City { set;get; }
    }
}
