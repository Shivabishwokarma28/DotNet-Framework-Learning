using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace _26_ValidationAttributes.Models
{
    public class Student
    {
        [Display(Name ="Enter Your Name")]
        [Required (ErrorMessage ="Name Must be required")]
        //[StringLength(20,MinimumLength =4, ErrorMessage ="Name Must be within 4 to 20 characters")]
       
        [MinLength(3,ErrorMessage ="Minum character more than 3 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email Must be required")]
        //[EmailAddress]
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$",ErrorMessage ="Invalid Email")]
        public string Email {  get; set; }

        [Required(ErrorMessage ="Age Must be required")]
        [Range(10,110,ErrorMessage ="Age Must be between 10 and 110")]
        public int? Age {  get; set; }

        [Required(ErrorMessage ="Password Must be Required")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[$@$!%*?&]).{8,}",ErrorMessage ="UpperCase,Lowercase,Number,Symbol,Min 8 character")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password Must be Required")]
        [Compare("Password",ErrorMessage ="Both Password must be identical")]
        [Display(Name ="Enter Conform Password")]
        public string ConformPassword { get; set; }
        

        [Required(ErrorMessage ="Number Must be required")]
        [RegularExpression(@"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]
                {2}[0 - 9]{8}$)| (^ [0 - 9]{ 3}- [0 - 9]{ 4}- [0 - 9]{ 4}$)",ErrorMessage ="Invalid Number")]
        public string Phone {  get; set; }

        [Required(ErrorMessage="Url Must be required")]
        [Url(ErrorMessage ="Invalid URL")]
        public string WebsiteUrl {  get; set; }
    }
}
