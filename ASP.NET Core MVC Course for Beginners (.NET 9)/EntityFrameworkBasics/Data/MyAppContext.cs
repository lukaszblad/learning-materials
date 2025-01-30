using Microsoft.EntityFrameworkCore;
using EntityFrameworkBasics.Models;

namespace EntityFrameworkBasics.Data
{
    public class MyAppContext : DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options) : base(options) { }

        public DbSet<MyItem> myItems { get; set; }
    }
}
