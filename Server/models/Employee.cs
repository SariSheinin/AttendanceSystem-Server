using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Server.models
{
    public class Employee
    {
        [Key]
        [StringLength(9)]
        public string Id { get; set; }
        [Required]
        [MaxLength(8)]
        public string Password { get; set; }
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }
        [Required]
        [Phone]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }
        [Required]
        public int Role { get; set; }
    }
}
