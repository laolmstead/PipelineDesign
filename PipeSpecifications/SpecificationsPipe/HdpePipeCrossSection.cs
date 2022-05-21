using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications.SpecificationsPipe
{
    public class HdpePipeCrossSection : PipeCrossSection
    {
        public HdpePipeCrossSection(int iDiameter)
        {
            HwCoefficient = HazenWilliamsCoefficient.Hdpe;
            NominalDiameter = iDiameter;
        }

        public int DrRating { get; set; }

        public HdpePipeType Type { get; set; }
    }
}
