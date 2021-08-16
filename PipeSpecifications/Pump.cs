using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications
{
    public class Pump
    {
        private double m_dPumpBhp;
        private double m_dMotorBhp;
        private double m_dUnitCost;

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

        public double UnitCost
        {
            get { return m_dUnitCost; }
            set { m_dUnitCost = value; }
        }
    }
}
