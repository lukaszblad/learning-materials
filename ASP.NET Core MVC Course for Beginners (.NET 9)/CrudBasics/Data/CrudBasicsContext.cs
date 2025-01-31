using Microsoft.EntityFrameworkCore;
using CrudBasics.Models;

namespace CrudBasics.Data
{
    public class CrudBasicsContext : DbContext
    {
        public CrudBasicsContext(DbContextOptions<CrudBasicsContext> options) : base(options) { }
        public DbSet<MyItem> MyItems { get; set; }
    }
}
