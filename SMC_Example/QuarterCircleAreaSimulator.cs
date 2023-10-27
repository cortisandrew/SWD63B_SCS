using SMC_Example;

internal class QuarterCircleAreaSimulator : ISimulator
{
    private Random random = new Random();

    public double Simulate()
    {
        // select a point at random
        double x = random.NextDouble();
        double y = random.NextDouble();

        // check whether point is on shaded area
        // (this changes depending on the problem/shaded area)
        bool isOnShadedArea = false;

        double distanceFromOrigin = Math.Sqrt((x * x) + (y * y));

        if (distanceFromOrigin < 1.0)
        {
            isOnShadedArea = true;
        }
        // else isOnShadedArea = false

        // if the point is on the shaded area
        if (isOnShadedArea)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}