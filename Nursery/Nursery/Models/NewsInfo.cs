namespace Nursery.Models
{
    public class NewsInfo : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime PostDate { get; set; }
        public ClassInfo ClassInfo { get; set; }
        public User Author { get; set; }

        public ICollection<Photos> Photos { get; set; }

    }
}
