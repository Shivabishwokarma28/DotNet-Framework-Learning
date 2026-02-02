using System.ComponentModel.DataAnnotations;

namespace _27_ValidationSummary.Models
{
    public class Student
    {
        [Display(Name = "Enter Your Name")]
        [Required(ErrorMessage = "Name Must be required")]
        //[StringLength(20,MinimumLength =4, ErrorMessage ="Name Must be within 4 to 20 characters")]

        [MinLength(3, ErrorMessage = "Minum character more than 3 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Must be required")]
        //[EmailAddress]
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age Must be required")]
        [Range(10, 110, ErrorMessage = "Age Must be between 10 and 110")]
        public int? Age { get; set; }

    }
}
