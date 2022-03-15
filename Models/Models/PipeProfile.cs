using PipelineDesignApi.Models.Pipe;
using PipelineDesignApi.Models.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineDesignApi.Models
{
    public class PipeProfile
    {
        public IList<PipeProfileSection> PipeProfiles { get; private set; } = new List<PipeProfileSection>();

        public FluidProperty? Fluid { get; set; }
    }
}
