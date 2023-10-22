namespace Nursery.Models
{
    public class Attendance : BaseEntity
    {
        public Student Student { get; set; }

        public DateTime PresenceDate { get; set; }

        public bool PresentStatus { get; set; }
    }
}
