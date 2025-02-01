using Microsoft.EntityFrameworkCore;
using OneToOneRelationship.Models;

namespace OneToOneRelationship.Data
{
    public class OneToOneRelationshipContext : DbContext
    {
        public OneToOneRelationshipContext(DbContextOptions<OneToOneRelationshipContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyItem>().HasData(
                new MyItem { Id = 4, Name="microphone", Price=40, SerialNumberId=10 }
            );
            modelBuilder.Entity<SerialNumber>().HasData(
                new SerialNumber { Id=10, Name="MIC344", MyItemId=4 }
            );
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<MyItem> MyItems { get; set; }
        public DbSet<SerialNumber> SerialNumber { get; set; }
    }
}
