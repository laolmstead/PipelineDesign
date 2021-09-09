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

        public string Description
        {
            get { return m_sDescription; }
            set { m_sDescription = value; }
        }

        public PipeHeadLossType HeadLossType
        {
            get { return m_HeadLossType; }
            set { m_HeadLossType = value; }
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

        public PipeCrossSection CrossSection
        {
            get { return m_PipeCrossSection; }
            set { m_PipeCrossSection = value; }
        }

        public List<Fitting> FittingsList
        {
            get { return m_FittingsList; }
        }
    }
}
