using Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsApi
{
    public class ProjectResults
    {
        private double m_dTotalLength;
        private PipeSectionResults m_PipeSectionResults;
        private EnergyResults m_EnergyResults;

        public ProjectResults()
        {
            m_EnergyResults = new EnergyResults();
            m_PipeSectionResults = new PipeSectionResults();
        }

        public double TotalLength
        {
            get { return m_dTotalLength; }
            set { m_dTotalLength = value; }
        }

        public PipeSectionResults PipeSection
        {
            get { return m_PipeSectionResults; }
            set { m_PipeSectionResults = value; }
        }

        public EnergyResults Energy
        {
            get { return m_EnergyResults; }
            set { m_EnergyResults = value; }
        }
    }
}
