using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEVE
{
    public static class Math
    {
        public static double StackingPenalty(int n, double value)
        {
            double[] penalties = new double[] {1, 0.869119808, 0.570583143511, 0.282955154023, 0.105992649743,
                                                        0.029991166533, 0.006410183118, 0.001034920483, 0.000126212683,
                                                        0.000011626754, 0.000000809046};
            var penalty = 0.0;

            if (n >= 0 && n < penalties.Length)
                penalty = penalties[n];

            return penalty * value;
        }
    }
}
