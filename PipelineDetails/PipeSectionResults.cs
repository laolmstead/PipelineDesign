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
        private double m_dHeadLoss;
        private double m_dVelocity;
        private double m_dStartStaion;
        private double m_dEndStation;
        private double m_dStartElevation;
        private double m_dEndElevation;
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

        public double HeadLoss
        {
            get { return m_dHeadLoss; }
            set { m_dHeadLoss = value; }
        }

        public double Velocity
        {
            get { return m_dVelocity; }
            set { m_dVelocity = value; }
        }

        public double StartStation
        {
            get { return m_dStartStaion; }
            set { m_dStartStaion = value; }
        }

        public double EndStation
        {
            get { return m_dEndStation; }
            set { m_dEndStation = value; }
        }

        public double StartElevation
        {
            get { return m_dStartElevation; }
            set { m_dStartElevation = value; }
        }

        public double EndElevation
        {
            get { return m_dEndElevation; }
            set { m_dEndElevation = value; }
        }

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
