using Specifications.SpecificationProperties;
using Specifications.SpecificationsPipe;
using Specifications.SpecificationsPump;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications
{
    public class ProjectData
    {
        private List<PipeSection> m_PipeSectionList;
        private List<Pump> m_PumpList;

        public ProjectData()
        {
            m_PipeSectionList = new List<PipeSection>();
            m_PumpList = new List<Pump>();
        }

        public double FlowRateGpm { get; set; }

        public List<PipeSection> PipeSectionList
        {
            get { return m_PipeSectionList; }
        }

        public List<Pump> PumpList
        {
            get { return m_PumpList; }
        }
    }
}
