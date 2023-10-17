// See https://aka.ms/new-console-template for more information
using SimulationExample;

Console.WriteLine("Hello, World!");

// initialise only once!!
Random r = new Random();

Simulation mySimulator = new Simulation(r);

const int N = 300000;

List<double> valueResults = new List<double>();

for (int i = 0; i < N; i++)
{
    var result = mySimulator.Simulate();
    // Console.WriteLine($"The outcome is {result.Item1}, with a value of {result.Item2}");
    valueResults.Add(result.Item2);
}

Console.WriteLine(
    valueResults.Average());

