# Non-Tracking Behavior Benchmark

This project demonstrates the performance characteristics of entity tracking behavior in Entity Framework Core, specifically focusing on the usage of `AsNoTracking` and `AsNoTrackingWithIdentityResolution` methods. The benchmark measures memory usage, query execution time and total entities created to compare the two approaches.

## Prerequisites

- .NET 5 SDK or later
- Entity Framework Core

## Getting Started

1. Clone the repository:

   ```shell
   git clone https://github.com/your-username/non-tracking-behavior-benchmark.git
   ```

2. Open the solution in your preferred IDE.

3. Build the solution to restore dependencies.

4. Modify the benchmark configuration and code as needed.

5. Run the benchmark project:

   ```shell
   dotnet run --project Benchmark.NonTrackingBehavior
   ```

6. Observe the benchmark results, including memory usage and query execution time, displayed in the console.

## Project Structure

The project consists of the following components:

- `Benchmark.NonTrackingBehavior`: Contains the benchmark logic and code for measuring memory usage and query execution time.
- `Benchmark.NonTrackingBehavior.Context`: Provides the Entity Framework context and entity configurations.
- `Benchmark.NonTrackingBehavior.Data`: Includes a mock data provider to generate test data for the benchmark.
- `Benchmark.NonTrackingBehavior.Extensions`: Contains extension methods for query execution with non-tracking behavior.
- `Benchmark.NonTrackingBehavior.Model`: Defines the entity models used in the benchmark.

## Customize and Extend

Feel free to customize and extend the benchmark project to fit your specific requirements. You can add more entities, relationships, or modify the queries to measure the performance characteristics of different scenarios. Additionally, you can leverage the provided memory usage and execution time measurement methods to profile other parts of your application.

## Contributing

Contributions to this project are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).