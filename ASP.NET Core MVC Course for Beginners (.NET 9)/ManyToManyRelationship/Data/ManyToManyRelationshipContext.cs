using Microsoft.EntityFrameworkCore;
using ManyToManyRelationship.Models;

namespace ManyToManyRelationship.Data
{
    public class ManyToManyRelationshipContext : DbContext
    {
        public ManyToManyRelationshipContext(DbContextOptions<ManyToManyRelationshipContext> options) : base(options) { }

        public DbSet<MyItem> MyItems { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<MyItemClient> MyItemClients { get; set; }
    }
}
