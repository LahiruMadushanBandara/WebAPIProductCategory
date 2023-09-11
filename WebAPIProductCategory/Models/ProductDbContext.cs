using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebAPIProductCategory.Models
{
    public class ProductDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public ProductDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("ProductDb"));
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
