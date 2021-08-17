using Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Results
{
    public class ProjectResults
    {
        private IReadOnlyList<PipeSectionResults> m_PipeSectionResultsList;
        private IReadOnlyList<EnergyResults> m_EnergyResultsList;
        private IReadOnlyList<Fittings> m_Fittings;
        private double m_dTdh;

        public IReadOnlyList<PipeSectionResults> PipeSectionResultsList
        {
            get { return m_PipeSectionResultsList; }
        }

        public IReadOnlyList<EnergyResults> EnergyResultsList
        {
            get { return m_EnergyResultsList; }
        }

        public IReadOnlyList<Fittings> FittingsList
        {
            get { return m_Fittings; }
        }
    }
}
