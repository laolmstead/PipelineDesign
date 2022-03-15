using PipelineDesignApi.Models.Pipe.CrossSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineDesignApi.Models.Pipe
{
    public class PipeProfileSection
    {
        public double StartStation { get; set; }
        public double EndStation { get; set; }
        public double StartElevation { get; set; }
        public double EndElevation { get; set; }

        public StandardPipeCrossSection? PipeCrossSection { get; set; }
    }
}
