using Microsoft.EntityFrameworkCore;

namespace Nursery.Models
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<ClassInfo> ClassInfos { get; set; }
        public DbSet<NewsInfo> NewsInfos { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parent>(pr =>
            {
                pr.OwnsOne(x => x.ContactInfo);
            });

            modelBuilder.Entity<Teacher>(pr =>
            {
                pr.OwnsOne(x => x.ContactInfo);
            });
        }
    }
}
