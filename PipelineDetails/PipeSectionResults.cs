using Specifications;
using System;

namespace Results
{
    public class PipeSectionResults
    {
        private Pipe m_Pipe;
        private Project m_Project;
        private string m_sDescription;
        private double m_iSectionLength;
        private double m_dStartStation;
        private double m_dGroundElevation;

        public Pipe PipeSpecs
        {
            get { return m_Pipe; }
            set { m_Pipe = value; }
        }

        public Project ProjectSpec
        {
            get { return m_Project; }
            set { m_Project = value; }
        }

        public string Description
        {
            get { return m_sDescription; }
            set { m_sDescription = value; }
        }

        public double SectionLength
        {
            get { return m_iSectionLength; }
            set { m_iSectionLength = value; }
        }

        public double StartStation
        {
            get { return m_dStartStation; }
            set { m_dStartStation = value; }
        }

        public double GroundElevation
        {
            get { return m_dGroundElevation; }
            set { m_dGroundElevation = value; }
        }

        public double FlowRateFps
        {
            get
            {
                return ProjectSpec.FlowRateGpm / 7.48052 / 60.0;
            }
        }

        public double Velocity
        {
            get
            {
                return FlowRateFps / (Math.PI/4.0 * Math.Pow((PipeSpecs.InnerDiameter / 12.0), 2.0));
            }
        }

        public double PipeHeadLoss
        {
            get
            {
                return 0.002083 * SectionLength * Math.Pow((100.0 / m_Pipe.HwCoefficient), 1.85) * 
                    (Math.Pow(ProjectSpec.FlowRateGpm, 1.85) / Math.Pow(PipeSpecs.InnerDiameter, 4.8655));
            }
        }
    }
}
