using System.ComponentModel.DataAnnotations;

namespace WebDevChallenge.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int ApplicationID {  get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public string? Notes { get; set; }
    }
}
