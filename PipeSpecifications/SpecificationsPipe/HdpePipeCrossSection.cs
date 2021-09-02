using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications.SpecificationsPipe
{
    public class HdpePipeCrossSection : PipeCrossSection
    {
        private int m_iDrRating;
        private HdpePipeType m_Type;

        public HdpePipeCrossSection(int iDiameter)
        {
            HwCoefficient = HazenWilliamsCoefficient.Hdpe;
            NominalDiameter = iDiameter;
        }

        public int DrRating
        {
            get { return m_iDrRating; }
            set { m_iDrRating = value; }
        }

        public HdpePipeType Type
        {
            get { return m_Type; }
            set { m_Type = value; }
        }
    }
}
