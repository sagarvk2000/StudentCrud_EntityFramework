using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCrud_EntityFramework.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Sid { get; set; }
        [Required]
        public string? Sname { get; set; }
        [Required]
        public decimal Percentage { get; set; }
        [Required]
        public string? Course { get; set; }

        [ScaffoldColumn(false)]
        public int IsActive { get; set; }
    }
}
