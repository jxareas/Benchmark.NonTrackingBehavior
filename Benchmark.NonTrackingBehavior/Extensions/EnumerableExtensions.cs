namespace Benchmark.NonTrackingBehavior.Extensions;

public static class EnumerableExtensions
{
    public static void PrintInstanceCount<T>(this IEnumerable<T> enumerable)
    {
        Console.WriteLine($"Number of instances of {typeof(T).Name}: {enumerable.Count()}");

        if (enumerable.Any())
        {
            var roleCount = enumerable.Select(x => x.GetType().GetProperty("Role").GetValue(x)).Distinct().Count();
            var companyCount = enumerable.Select(x => x.GetType().GetProperty("Company").GetValue(x)).Distinct().Count();

            Console.WriteLine($"Number of instances of {typeof(T).Name}.Role: {roleCount}");
            Console.WriteLine($"Number of instances of {typeof(T).Name}.Company: {companyCount}");
        }
    }
}
