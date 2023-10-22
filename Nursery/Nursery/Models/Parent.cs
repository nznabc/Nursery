namespace Nursery.Models
{
    public class Parent : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public User User { get; set; }

        public ContactInfo ContactInfo { get; set; }

        public ICollection<Student> students { get; set; }

    }

}
