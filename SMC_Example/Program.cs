using SMC_Example;

// the driver runs the Monte Carlo Experiments
SMC_Driver driver = new SMC_Driver(
    new QuarterCircleAreaSimulator()); // The simulator describes what each experiment is going to be like

// new RectangleAreaSimulator()

int[] simulation_Size = new int[] { 100, 10000, 100000000 };

foreach (int simulations in simulation_Size)
{
    // The exact area of the quarter circle (mu) is Pi/4

    // We run the simulation "n" times
    // to obtain the value mu hat subscript n
    // This is an estimate (hat) of mu using exactly n simulations
    double estimated_area = driver.RunSimulations(simulations);

    Console.WriteLine($"The result using {simulations} simulations is {estimated_area}.");
    Console.WriteLine($"The estimated value for Pi is {estimated_area * 4}");
}