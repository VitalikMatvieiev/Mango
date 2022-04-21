
using Mango.Services.ProductAPI.DbContext.Models;

namespace Mango.Services.ProductAPI.DbContext
{
    using Microsoft.EntityFrameworkCore;
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
