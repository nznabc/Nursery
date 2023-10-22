namespace Nursery.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public RoleType RoleType { get; set; }
    }
}
