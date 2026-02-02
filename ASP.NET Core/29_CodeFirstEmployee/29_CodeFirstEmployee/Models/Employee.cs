using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _29_CodeFirstEmployee.Models
{
    public class Employee
    {
        [Key]
       
        public int Id { get; set; }
        [MaxLength(30, ErrorMessage = "Max character 30")]
        [Column("Emp_Name",TypeName ="VARCHAR(30)")]
        [Required(ErrorMessage = "Name Must be requires")]
        public string Name { get; set; }
        [Column("Emp_Address", TypeName = "VARCHAR(30)")]
        [Required(ErrorMessage = "Address Must be requires")]
        [MaxLength(30,ErrorMessage ="Max character 30")]
        public string Address {  get; set; }
        [Column("Emp_Designation", TypeName = "VARCHAR(30)")]

        [Required(ErrorMessage = "Designation Must be requires")]
        public string Designation {  get; set; }
    }
}
