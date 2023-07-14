using Benchmark.NonTrackingBehavior.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Benchmark.NonTrackingBehavior.Configuration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Navigation(u => u.Role).AutoInclude();
        builder.Navigation(u => u.Company).AutoInclude();
    }
}
