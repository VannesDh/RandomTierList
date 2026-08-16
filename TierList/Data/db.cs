
using TierList.Models;
using Microsoft.EntityFrameworkCore;
namespace TierList.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<TierContainer> TierContainers { get; set; }
    public DbSet<Tier> Tiers { get; set; }
    public DbSet<Item> Items { get; set; }
}