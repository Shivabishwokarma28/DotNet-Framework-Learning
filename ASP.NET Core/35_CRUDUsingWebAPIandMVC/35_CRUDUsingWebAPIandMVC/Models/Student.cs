using System.ComponentModel.DataAnnotations;

namespace _35_CRUDUsingWebAPIandMVC.Models
{
    
        public class Student
        {

            public int id { get; set; }
        [Required(ErrorMessage ="Name Must be required")]
            public string stName { get; set; }
        [Required(ErrorMessage = "Phone Must be required")]
        public string stPhone { get; set; }
        [Required(ErrorMessage = "Roll Number Must be required")]
        public int stRoll { get; set; }
        }

    
}
