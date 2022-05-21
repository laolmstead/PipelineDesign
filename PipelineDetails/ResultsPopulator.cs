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
        private ProjectData m_ProjectData;

        public ResultsPopulator(ProjectData projectData)
        {
            m_ProjectData = projectData;
        }

        public bool Populate(ProjectResults projectResults)
        {
            bool bRet = true;

            projectResults.TotalLength = CalculateTotalPipeLength();

            foreach (PipeSectionResults pipeSectionResults in projectResults.PipeSectionList)
            {
                bRet &= PopulatePipeSectionResults(pipeSectionResults);
            }

            return bRet;
        }

        public bool PopulatePipeSectionResults(PipeSectionResults pipeSectionResults)
        {
            foreach (PipeSection section in m_ProjectData.PipeSectionList)
            {
                PipeCrossSection crossSection = section.CrossSection;
                PopulateCrossSection(crossSection, pipeSectionResults.CrossSectionResults);

                // Calculate minor losses from fittings
                double dEquivalentLength = 0.0;

                foreach (Fitting fitting in section.FittingsList)
                {
                    dEquivalentLength += (fitting.LossCoefficient * crossSection.NominalDiameter / 12.0);

                    // Add fitting to fitting result list
                    FittingResults fittingResults = new FittingResults();
                    PopulateFitting(fitting, fittingResults);
                    pipeSectionResults.FittingResults.Add(fittingResults);
                }

                // Calculate pipe head loss
                double dSectionEquivalentLength = dEquivalentLength + (section.EndStation - section.StartStation);

                switch (section.HeadLossType)
                {
                    case (PipeHeadLossType.PipeEntrance):
                        pipeSectionResults.HeadLoss = 0.00129 * Math.Pow(m_ProjectData.FlowRateGpm, 2) * Math.Pow(crossSection.InnerDiameter, 4);
                        break;
                    case (PipeHeadLossType.PipeSection):
                        pipeSectionResults.HeadLoss = 0.002083 * Math.Pow((100.0 / crossSection.HwCoefficient), 1.85) * Math.Pow(m_ProjectData.FlowRateGpm, 1.85) *
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

        private bool PopulatePumpResults(PumpResults pumpResults)
        {

            return true;
        }

        private bool PopulateCrossSection(PipeCrossSection pipeCrossSection, PipeCrossSectionResults pipeCrossSectionResults)
        {
            pipeCrossSectionResults.NominalDiameter = pipeCrossSection.NominalDiameter;
            pipeCrossSectionResults.InnerDiameter = pipeCrossSection.InnerDiameter;
            pipeCrossSectionResults.OuterDiameter = pipeCrossSection.OuterDiameter;
            pipeCrossSectionResults.PressureRating = pipeCrossSection.PressureRating;
            pipeCrossSectionResults.HwCoefficient = pipeCrossSection.HwCoefficient;
            pipeCrossSectionResults.CostPerLinearFt = pipeCrossSection.CostPerLinearFt;

            return true;
        }

        private bool PopulateFitting(Fitting fitting, FittingResults fittingResults)
        {
            fittingResults.FittingName = fitting.FittingName;
            fittingResults.LossCoefficient = fitting.LossCoefficient;
            fittingResults.EquivalentLength = fitting.EquivalentLength;

            return true;
        }

        private bool CalculateFrictionLossToEndOfPipe(ProjectResults results)
        {

            return true;
        }

        private double CalculateTotalPipeLength()
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
