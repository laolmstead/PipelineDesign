using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Results
{
    public class EnergyResults
    {
        private double m_dHydraulicGradeLine;
        private double m_dPipelinePressure;
        private double m_dEnergyGradeLine;

        public double HydraulicGradeLine
        {
            get { return m_dHydraulicGradeLine; }
            set { m_dHydraulicGradeLine = value; }
        }

        public double PipelinePressure
        {
            get { return m_dPipelinePressure; }
            set { m_dPipelinePressure = value; }
        }

        public double EnergyGradeLine
        {
            get { return m_dEnergyGradeLine; }
            set { m_dEnergyGradeLine = value; }
        }
    }
}
