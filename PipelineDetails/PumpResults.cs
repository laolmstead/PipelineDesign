using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsApi
{
    public class PumpResults
    {
        private ProjectResults m_Parent;

        public PumpResults(ProjectResults parent)
        {
            m_Parent = parent;
        }

        public ProjectResults Parent
        {
            get { return m_Parent; }
        }

        public double TdhRequired { get; set; }

        public double FlowPerPump { get; set; }

        public double PumpBhp { get; set; }

        public double MotorBhp { get; set; }
    }
}
