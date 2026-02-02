using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _28_CodeFirstApproach.Models
{
    public class Student
    {
        [Key]

        public int Id { get; set; }
        [Column("Std_Name",TypeName ="VARCHAR(30)")]
        [MaxLength(20, ErrorMessage = "Max character 30")]
        [Required(ErrorMessage = "Name Must be required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Gender Must be required")]
        [MaxLength(20,ErrorMessage ="Max character 15")]
        [Column("Std_Gender",TypeName ="    VARCHAR(15)")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Age Must be required")]
        [Range(3,30)]
        public int Age { get; set; }
        [Required(ErrorMessage = "Standard Must be required")]
        public int Standard { get; set; }
    }
}
