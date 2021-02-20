using System.ComponentModel.DataAnnotations;

namespace API.DTOs
// Register DTO to get user set up in DB
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
    }
}