using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsApi
{
    public class PumpResults
    {
        private double m_dTdh;
        private double m_dFlowPerPump;
        private double m_dPumpBhp;
        private double m_dMotorBhp;

        public PumpResults()
        {

        }

        public double Tdh
        {
            get { return m_dTdh; }
            set { m_dTdh = value; }
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
