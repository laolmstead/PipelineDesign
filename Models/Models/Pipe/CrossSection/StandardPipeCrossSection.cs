using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineDesignApi.Models.Pipe.CrossSection
{
    public class StandardPipeCrossSection
    {
        public string? Id { get; set; }

        public double NominalDiameter { get; set; }

        public double InnerDiameter { get; set; }

        public double OuterDiameter { get; set; }

        public double PressureRating { get; set; }

        public PipeType PipeType { get; set; }

        public int HwCoefficient { get; set; }

        public double CostPerLf { get; set; }
    }
}
