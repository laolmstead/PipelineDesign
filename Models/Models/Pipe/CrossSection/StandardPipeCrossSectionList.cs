using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineDesignApi.Models.Pipe.CrossSection
{
    public class StandardPipeCrossSectionList
    {
        public IList<StandardPipeCrossSection> StandardPipeCrossSections { get; private set; } = new List<StandardPipeCrossSection>();
    }
}
