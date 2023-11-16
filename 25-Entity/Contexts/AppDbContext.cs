using _25_Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace _25_Entity.Contexts
{
    public class AppDbContext : DbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //{
        //}

        public DbSet<Product> Products { get; set; }
    }

}
