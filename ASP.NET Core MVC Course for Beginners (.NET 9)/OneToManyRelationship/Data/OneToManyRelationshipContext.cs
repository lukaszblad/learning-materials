using Microsoft.EntityFrameworkCore;
using OneToManyRelationship.Models;

namespace OneToManyRelationship.Data
{
    public class OneToManyRelationshipContext : DbContext
    {
        public OneToManyRelationshipContext(DbContextOptions<OneToManyRelationshipContext> options) : base(options) { }
        public DbSet<MyItem> MyItems { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
