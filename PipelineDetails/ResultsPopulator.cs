using Specifications;
using Specifications.SpecificationProperties;
using Specifications.SpecificationsPipe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsApi
{
    public class ResultsPopulator
    {
        // Data
        private Project m_Project;
        private double m_TotalPipeLength;

        public ResultsPopulator(Project project)
        {
            m_Project = project;
        }

        public FluidProperties Fluid
        {
            get
            {
                return m_Project.Fluid;
            }
        }

        public double TotalPipeLength
        {
            get
            {
                m_TotalPipeLength = 0.0;

                foreach (PipeSection section in m_Project.PipeSectionList)
                {
                    m_TotalPipeLength += (section.EndStation - section.StartStation);
                }

                return m_TotalPipeLength;
            }
        }

        public bool Populate(ProjectResults projectResults)
        {
            bool bRet = true;

            PipeSectionResults pipeSectionResults = new PipeSectionResults();

            bRet &= PopulatePipeSectionResults(pipeSectionResults);

            return bRet;
        }

        public bool PopulatePipeSectionResults(PipeSectionResults pipeSectionResults)
        {
            foreach (PipeSection section in m_Project.PipeSectionList)
            {
                PipeCrossSection crossSection = section.CrossSection;

                // Calculate minor losses from fittings
                double dEquivalentLength = 0.0;

                foreach (Fitting fitting in section.FittingsList)
                {
                    dEquivalentLength += (fitting.LossCoefficient * crossSection.NominalDiameter / 12.0);
                }

                // Calculate pipe head loss
                double dSectionEquivalentLength = dEquivalentLength + (section.EndStation - section.StartStation);

                if (section.HeadLossType == PipeHeadLossType.PipeEntrance)
                {
                    pipeSectionResults.HeadLoss = 0.00129 * Math.Pow(Fluid.FlowRateGpm, 2) * Math.Pow(crossSection.InnerDiameter, 4);
                }
                else if (section.HeadLossType == PipeHeadLossType.PipeSection)
                {
                    pipeSectionResults.HeadLoss = 0.002083 * Math.Pow((100.0 / crossSection.HwCoefficient), 1.85) * Math.Pow(Fluid.FlowRateGpm, 1.85) * 
                                    dSectionEquivalentLength / (Math.Pow(crossSection.InnerDiameter, 4.8655));
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
