using Specifications;
using Specifications.SpecificationProperties;
using Specifications.SpecificationsPipe;
using System;

namespace PipelineDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up sample project
            ProjectData project = new ProjectData();

            // Set fluid properties
            FluidProperties fluid = project.Fluid;
            fluid.FlowRateGpm = 350.0;
            fluid.FluidDensity = 62.4;

            // Set pipe properties
            var v = project.PipeSectionList;

            // Create pipe cross section
            PipeSection startSection = new PipeSection();
            PipeCrossSection startXSect = startSection.CrossSection;
            HdpePipeCrossSection crossSection1 = new HdpePipeCrossSection(6);
            startXSect.HwCoefficient = 150;
            startXSect.InnerDiameter = 4.810;
            startXSect.OuterDiameter = 6.625;
            startXSect.NominalDiameter = 6.0;
            startXSect.PressureRating = 335.0;
        }
    }
}
