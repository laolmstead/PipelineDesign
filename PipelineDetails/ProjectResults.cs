using Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsApi
{
    public class ProjectResults
    {
        private IList<PipeSectionResults> m_PipeSectionResults;    // convert to list
        private PumpResults m_PumpResults;
        private EnergyResults m_EnergyResults;

        public ProjectResults()
        {
            m_PipeSectionResults = new List<PipeSectionResults>();
            m_PumpResults = new PumpResults(this);
            m_EnergyResults = new EnergyResults(this);
        }

        public double TotalLength { get; set; }

        public double HighPointElevation { get; set; }

        public double DischargeElevation { get; set; }

        public double MaxWaterLevelAtPumpStation { get; set; }

        public double FrictionLossToHighPoint { get; set; }

        public double FrictionLossToEndOfPipe { get; set; }

        public double StaticHead
        {
            get { return DischargeElevation - m_dMaxPumpStationWaterElevation; }
        }

        public double Tdh
        {
            get { return this.StaticHead + this.FrictionLossToEndOfPipe; }
        }

        public IList<PipeSectionResults> PipeSectionList
        {
            get { return m_PipeSectionResults; }
        }

        public PumpResults Pump
        {
            get { return m_PumpResults; }
            set { m_PumpResults = value; }
        }

        public EnergyResults Energy
        {
            get { return m_EnergyResults; }
            set { m_EnergyResults = value; }
        }
    }
}
