using System.Diagnostics;
using Benchmark.NonTrackingBehavior.Context;
using Benchmark.NonTrackingBehavior.Data;
using Benchmark.NonTrackingBehavior.Extensions;

using (var dbContext = new AppDbContext())
{
    var mockDataProvider = new MockDataProvider(dbContext);
    mockDataProvider.CreateMockData();
}

using (var dbContext = new AppDbContext())
{
    Console.WriteLine("Using AsNoTracking:");
    MeasureMemoryAndTime(() =>
        {
            var nonTracking = dbContext.Users.ToListNonTracking();
            nonTracking.PrintInstanceCount();
        });

    Console.WriteLine();

    Console.WriteLine("Using AsNoTrackingWithIdentityResolution:");
    MeasureMemoryAndTime(() =>
        {
            var nonTrackingWithResolution = dbContext.Users.ToListNonTrackingWithIdentityResolution();
            nonTrackingWithResolution.PrintInstanceCount();
        });
}

static void MeasureMemoryAndTime(Action action)
{
    // Measure memory usage
    long initialMemory = GC.GetTotalMemory(true);

    // Measure execution time
    Stopwatch stopwatch = Stopwatch.StartNew();

    // Execute the action
    action.Invoke();

    stopwatch.Stop();

    // Measure memory usage after execution
    long finalMemory = GC.GetTotalMemory(true);
    long memoryUsed = finalMemory - initialMemory;

    Console.WriteLine($"Memory used: {memoryUsed} bytes");
    Console.WriteLine($"Execution time: {stopwatch.ElapsedMilliseconds} ms");
}

