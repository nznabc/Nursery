namespace Nursery.Models
{
    public class Photos : BaseEntity
    {
        public string Description { get; set; }
        public string Path { get; set; } = string.Empty;
    }
}
