using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsApi
{
    public class PipeSectionResults
    {
        private ProjectResults m_Parent;
        private PipeCrossSectionResults m_PipeCrossSectionResults;
        private IList<FittingResults> m_FittingResults;

        public PipeSectionResults(ProjectResults parent)
        {
            m_Parent = parent;

            m_PipeCrossSectionResults = new PipeCrossSectionResults();
            m_FittingResults = new List<FittingResults>();
        }

        public ProjectResults Parent
        {
            get { return m_Parent; }
        }

        public double HeadLoss { get; set; }

        public double Velocity { get; set; }

        public double StartStation { get; set; }

        public double EndStation { get; set; }

        public double StartElevation { get; set; }

        public double EndElevation { get; set; }

        public PipeCrossSectionResults CrossSectionResults
        {
            get { return m_PipeCrossSectionResults; }
        }

        public IList<FittingResults> FittingResults
        {
            get { return m_FittingResults; }
        }
    }
}
