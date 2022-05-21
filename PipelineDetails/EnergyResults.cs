using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsApi
{
    public class EnergyResults
    {
        private ProjectResults m_Parent;

        public EnergyResults(ProjectResults parent)
        {
            m_Parent = parent;
        }

        public ProjectResults Parent
        {
            get { return m_Parent; }
        }

        public double HydraulicGradeLine { get; set; }

        public double PipelinePressure { get; set; }

        public double EnergyGradeLine { get; set; }
    }
}
