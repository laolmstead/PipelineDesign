using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications
{
    public class Project
    {
        private double m_dFlowRateGpm;
        private double m_dTotalPipeLength;
        private double m_dFluidDensity;

        public double FlowRateGpm
        {
            get { return m_dFlowRateGpm; }
            set { m_dFlowRateGpm = value; }
        }

        public double TotalPipeLength
        {
            get { return m_dTotalPipeLength; }
            set { m_dTotalPipeLength = value; }
        }

        public double FluidDensity
        {
            get { return m_dFluidDensity; }
            set { m_dFluidDensity = value; }
        }
    }
}
