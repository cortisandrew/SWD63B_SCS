using SMC_Example;

// the driver runs the Monte Carlo Experiments
SMC_Driver driver = new SMC_Driver(
    new RectangleAreaSimulator()); // The simulator describes what each experiment is going to be like

double area = driver.RunSimulations(1000000);

Console.WriteLine(area);