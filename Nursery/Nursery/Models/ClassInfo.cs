namespace Nursery.Models
{
    public class ClassInfo : BaseEntity
    {
        public string ClassName { get; set; } = string.Empty;
        public Teacher Teacher { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<NewsInfo> NewsInfos { get; set; }
    }
}
