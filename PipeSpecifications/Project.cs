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
        private List<PipeCrossSection> m_PipeList;
        private List<Pump> m_PumpList;

        public Project()
        {
            m_PipeList = new List<PipeCrossSection>();
            m_PumpList = new List<Pump>();
        }

        public List<PipeCrossSection> PipeList
        {
            get { return m_PipeList; }
        }

        public List<Pump> PumpList
        {
            get { return m_PumpList; }
        }
    }
}
