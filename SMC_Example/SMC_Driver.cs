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

        public SMC_Driver(ISimulator simulator)
        {
            this.simulator = simulator;
        }

        public double RunSimulations(int n)
        {
            List<double> y_i_List = new List<double>(n);

            for (int i = 0; i<n;i++)
            {
                double y_i = simulator.Simulate();
                y_i_List.Add(y_i);
            }

            // investigate the list later
            return y_i_List.Average();
        }
    }
}
