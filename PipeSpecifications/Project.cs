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
    public class Project
    {
        private FluidProperties m_FluidProperties;
        private List<PipeSection> m_PipeSectionList;
        private List<Pump> m_PumpList;

        public Project()
        {
            m_FluidProperties = new FluidProperties();
            m_PipeSectionList = new List<PipeSection>();
            m_PumpList = new List<Pump>();
        }

        public FluidProperties Fluid
        {
            get { return m_FluidProperties; }
        }

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
