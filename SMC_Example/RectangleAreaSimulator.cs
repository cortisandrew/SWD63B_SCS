using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC_Example
{
    public class RectangleAreaSimulator : ISimulator
    {
        private Random random = new Random();
        public double Simulate()
        {
            // select a point at random
            double x = random.NextDouble();
            double y = random.NextDouble();

            // check whether point is on shaded area
            // (this changes depending on the problem/shaded area)
            bool isOnShadedArea = (y < 0.5);

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
}
