namespace Nursery.Models
{
    public class Photo : BaseEntity
    {
        public string Description { get; set; }
        public string Path { get; set; } = string.Empty;
    }
}
