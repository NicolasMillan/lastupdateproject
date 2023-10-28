using Microsoft.EntityFrameworkCore;
using ScamStore.Models;

namespace WorldDominion.Models
{
   public class ApplicationDbContext : DbContext
  {
     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

     // Change to be your model(s) and table(s)
     public DbSet<Department> Department { get; set; }
     public DbSet<Product> Product { get; set; }
     
  }
}