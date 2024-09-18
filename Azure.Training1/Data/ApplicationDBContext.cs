using Azure.Training1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Azure.Training1.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
