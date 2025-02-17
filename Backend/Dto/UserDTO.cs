namespace Backend.Models
{
    public class UserDTO
    {
        public Guid UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String NormalizedEmail { get; set; }
        public bool IsActive { get; set; }
    }
}
