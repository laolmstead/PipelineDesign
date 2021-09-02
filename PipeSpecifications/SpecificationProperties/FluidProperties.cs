using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications.SpecificationProperties
{
    public class FluidProperties
    {
        private double m_dFlowRateGpm;
        private double m_dFluidDensity;

        public double FlowRateGpm
        {
            get { return m_dFlowRateGpm; }
            set { m_dFlowRateGpm = value; }
        }

        public double FluidDensity
        {
            get { return m_dFluidDensity; }
            set { m_dFluidDensity = value; }
        }
    }
}
