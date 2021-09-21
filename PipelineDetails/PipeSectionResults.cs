using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsApi
{
    public class PipeSectionResults
    {
        private double m_dHeadLoss;
        private double m_dVelocity;

        public PipeSectionResults()
        {
            m_dHeadLoss = 0.0;
            m_dVelocity = 0.0;
        }

        public double HeadLoss
        {
            get { return m_dHeadLoss; }
            set { m_dHeadLoss = value; }
        }

        public double Velocity
        {
            get { return m_dVelocity; }
            set { m_dVelocity = value; }
        }
    }
}
