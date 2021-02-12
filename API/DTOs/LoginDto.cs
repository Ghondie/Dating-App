namespace API.DTOs

// Login DTO to get user set up in DB
{
    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}