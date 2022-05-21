using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsApi
{
    public class FittingResults
    {
        public string FittingName { get; set; }

        public int LossCoefficient { get; set; }

        public double EquivalentLength { get; set; }
    }
}
