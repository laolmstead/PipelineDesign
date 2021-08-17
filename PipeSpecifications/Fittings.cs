using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications
{
    public class Fittings
    {
        private string m_sItemName;
        private int m_iLossCoefficient;
        private double m_dEquivalentLength;

        public string ItemName
        {
            get { return m_sItemName; }
            set { m_sItemName = value; }
        }

        public int LossCoefficient
        {
            get { return m_iLossCoefficient; }
            set { m_iLossCoefficient = value; }
        }

        public double EquivalentLength
        {
            get { return m_dEquivalentLength; }
            set { m_dEquivalentLength = value; }
        }
    }
}
