using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } 
        [Required(ErrorMessage = "Phone is required")]
        [Length(10, 30)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Position is required")]
        public string Position { get; set; }
    }
}
