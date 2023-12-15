using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMC_Example
{
    public class SMC_Driver
    {
        ISimulator simulator;

        List<double> y_i_List = new List<double>();

        public SMC_Driver(ISimulator simulator)
        {
            this.simulator = simulator;
        }

        public void RunSimulations(int n)
        {
            y_i_List = new List<double>(n);

            for (int i = 0; i<n;i++)
            {
                double y_i = simulator.Simulate();
                y_i_List.Add(y_i);
            }

            // investigate the list later
            // return y_i_List.Average();
        }

        public double GetEstimatedMeanFromSimulations()
        {
            if (y_i_List.Count == 0)
            {
                throw new InvalidOperationException("You must first run the SMC before obtaining any results!");
            }

            return y_i_List.Average();
        }

        public double EstimateStandardDeviationFromSimulations()
        {
            if (y_i_List.Count == 0)
            {
                throw new InvalidOperationException("You must first run the SMC before obtaining any results!");
            }

            //Compute the Average
            double avg = y_i_List.Average();

            //Perform the Sum of (value-avg)^2
            double sum = y_i_List.Sum(d => (d - avg) * (d - avg));

            //Put it all together
            return Math.Sqrt(sum / (y_i_List.Count - 1));
        }
    }
}
