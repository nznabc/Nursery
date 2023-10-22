namespace Nursery.Models
{
    public class Student : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Parent Parent { get; set; }
        public ClassInfo ClassInfo { get; set; }

        public ICollection<Attendance> Attendances { get; set; }
    }
}
