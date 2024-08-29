using FlowerShop_Management.Models.Flowers;
using Microsoft.EntityFrameworkCore;

namespace FlowerShop_Management.Data
{
    public class FlowerDbContext : DbContext
    {
        public FlowerDbContext(DbContextOptions<FlowerDbContext> options) : base(options) { }

        public DbSet<Flower> Flowers { get; set; }
    }
}
