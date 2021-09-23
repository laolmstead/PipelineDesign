﻿using Specifications;
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
        private ProjectData m_ProjectData;

        public ResultsPopulator(ProjectData projectData)
        {
            m_ProjectData = projectData;
        }

        public FluidProperties Fluid
        {
            get
            {
                return m_ProjectData.Fluid;
            }
        }

        public bool Populate(ProjectResults projectResults)
        {
            bool bRet = true;

            projectResults.TotalLength = CalculateTotalPipeLength(projectResults.PipeSection);

            bRet &= PopulatePipeSectionResults(projectResults.PipeSection);

            return bRet;
        }

        public bool PopulatePipeSectionResults(PipeSectionResults pipeSectionResults)
        {
            foreach (PipeSection section in m_ProjectData.PipeSectionList)
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

                switch (section.HeadLossType)
                {
                    case (PipeHeadLossType.PipeEntrance):
                        pipeSectionResults.HeadLoss = 0.00129 * Math.Pow(Fluid.FlowRateGpm, 2) * Math.Pow(crossSection.InnerDiameter, 4);
                        break;
                    case (PipeHeadLossType.PipeSection):
                        pipeSectionResults.HeadLoss = 0.002083 * Math.Pow((100.0 / crossSection.HwCoefficient), 1.85) * Math.Pow(Fluid.FlowRateGpm, 1.85) *
                                    dSectionEquivalentLength / (Math.Pow(crossSection.InnerDiameter, 4.8655));
                        break;
                    default:
                        break;
                }

                // Set velocity for each section of pip
                pipeSectionResults.Velocity = (Math.PI / 4.0) * Math.Pow((crossSection.InnerDiameter / 12), 4.0);
            }

            return true;
        }

        private double CalculateTotalPipeLength(PipeSectionResults pipeSectionResults)
        {
            double dTotalLength = 0.0;

            foreach (PipeSection section in m_ProjectData.PipeSectionList)
            {
                dTotalLength += (section.EndStation - section.StartStation);
            }

            return dTotalLength;
        }
    }
}
