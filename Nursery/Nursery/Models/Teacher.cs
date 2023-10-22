namespace Nursery.Models
{
    public class Teacher : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public User User { get; set; }

        public ContactInfo ContactInfo { get; set; }

        public ICollection<ClassInfo> ClassInfos { get; set; }

    }

}
