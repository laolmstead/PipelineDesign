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
        private double m_dTdhRequired;
        private double m_dFlowPerPump;
        private double m_dPumpBhp;
        private double m_dMotorBhp;

        public PumpResults(ProjectResults parent)
        {
            m_Parent = parent;
        }

        public ProjectResults Parent
        {
            get { return m_Parent; }
        }

        public double TdhRequired
        {
            get { return m_dTdhRequired; }
            set { m_dTdhRequired = value; }
        }

        public double FlowPerPump
        {
            get { return m_dFlowPerPump; }
            set { m_dFlowPerPump = value; }
        }

        public double PumpBhp
        {
            get { return m_dPumpBhp; }
            set { m_dPumpBhp = value; }
        }

        public double MotorBhp
        {
            get { return m_dMotorBhp; }
            set { m_dMotorBhp = value; }
        }
    }
}
