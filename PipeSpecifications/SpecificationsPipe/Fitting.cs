using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications.SpecificationsPipe
{
    public class Fitting
    {
        private string m_sFittingName;
        private int m_iLossCoefficient;
        private double m_dEquivalentLength;

        public Fitting()
        {

        }

        public string FittingName
        {
            get { return m_sFittingName; }
            set { m_sFittingName = value; }
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
