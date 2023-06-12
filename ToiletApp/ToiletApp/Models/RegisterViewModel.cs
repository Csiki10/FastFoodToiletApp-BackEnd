namespace ToiletApp.Models
{
    public class RegisterViewModel
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ContentType { get; set; }
        public byte[]? Data { get; set; }
        public string Password { get; set; }

    }
}
