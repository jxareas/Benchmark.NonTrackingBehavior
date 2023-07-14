using Benchmark.NonTrackingBehavior.Constants;
using Benchmark.NonTrackingBehavior.Context;
using Benchmark.NonTrackingBehavior.Model;

namespace Benchmark.NonTrackingBehavior.Data;

public class MockDataProvider
{
    private readonly AppDbContext _dbContext;

    public MockDataProvider(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void CreateMockData()
    {
        _dbContext.Database.EnsureDeleted();
        _dbContext.Database.EnsureCreated();

        for (int i = 1; i <= AppConstants.MaxNumberOfRelations; i++)
        {
            var role = new Role { Name = $"Role {i}" };
            _dbContext.Roles.Add(role);

            var company = new Company { Name = $"Company {i}" };
            _dbContext.Companies.Add(company);

            for (int j = 1; j <= AppConstants.MaxNumberOfEntities / AppConstants.MaxNumberOfRelations; j++)
            {
                var user = new User { Name = $"User {i}-{j}", Role = role, Company = company };
                _dbContext.Users.Add(user);
            }
        }

        _dbContext.SaveChanges();
    }
}
