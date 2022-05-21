using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications.SpecificationsPipe
{
    public abstract class PipeCrossSection
    {
        public double NominalDiameter { get; set; }

        public double InnerDiameter { get; set; }

        public double OuterDiameter { get; set; }

        public double PressureRating { get; set; }

        public int HwCoefficient { get; set; }

        public double CostPerLinearFt { get; set; }
    }
}
