using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications.SpecificationsPipe
{
    public class PipeSection
    {
        private string m_sDescription;
        private PipeHeadLossType m_HeadLossType;
        private double m_dStartStaion;
        private double m_dEndStation;
        private double m_dStartElevation;
        private double m_dEndElevation;
        private PipeCrossSection m_PipeCrossSection;
        private List<Fitting> m_FittingsList;

        public PipeSection()
        {
            m_FittingsList = new List<Fitting>();
        }

        public string Description { get; set; }

        public PipeHeadLossType HeadLossType { get; set; }

        public double StartStation { get; set; }

        public double EndStation { get; set; }

        public double StartElevation { get; set; }

        public double EndElevation { get; set; }

        public PipeCrossSection CrossSection { get; set; }

        public List<Fitting> FittingsList
        {
            get { return m_FittingsList; }
        }
    }
}
