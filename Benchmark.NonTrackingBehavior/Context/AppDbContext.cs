using System.Reflection;
using Benchmark.NonTrackingBehavior.Constants;
using Benchmark.NonTrackingBehavior.Model;
using Microsoft.EntityFrameworkCore;

namespace Benchmark.NonTrackingBehavior.Context;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Company> Companies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseInMemoryDatabase(AppConstants.DatabaseName);

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

}
