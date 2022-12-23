using Microsoft.EntityFrameworkCore;

namespace Salon.Models
{
  public class BestRestaurantContext : DbContext
  {
    public DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }

    public SalonContext(DbContextOptions options) : base(options) { }
  }
}