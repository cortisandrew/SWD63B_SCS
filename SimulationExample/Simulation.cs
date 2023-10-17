using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationExample
{
    internal class Simulation
    {
        private Random r;
        internal Simulation(Random r)
        {
            this.r = r;
        }

        internal (string, float) Simulate()
        {
            // Randomly choose between the possible outcomes
            // calculate the result
            double randomResult = r.NextDouble();

            if (randomResult < 0.25)
            {
                // the result is HH with probability of 0.25
                return ("HH", 3.5f);
            } else if (randomResult < 0.5)
            {
                // the result is HT with probability of 0.5 - 0.25 = 0.25
                return ("HT", -1.0f);
            } else if (randomResult < 0.75)
            {
                // the result is TH with probability of 0.75 - 0.5 = 0.25
                return ("TH", -1.0f);
            } else
            {
                // otherwise, the remaining probability is 0.25
                return ("TT", -2.0f);
            }
            /*
            char firstResult = r.NextDouble() < 0.5 ? 'H' : 'T';
            char secondResult = r.NextDouble() < 0.5 ? 'H' : 'T';

            string outcome = String.Concat(firstResult, secondResult);
            */




            // return the value
        }
    }
}
