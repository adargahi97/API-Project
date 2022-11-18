using Microsoft.EntityFrameworkCore;
using ProjectApi.Models;

namespace ProjectApi.Daos
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
