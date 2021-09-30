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
        private double m_dTotalLength;
        private double m_dHighPointElevation;
        private double m_dDischargeElevation;
        private double m_dMaxPumpStationWaterElevation;
        private double m_dFrictionLossToHighPoint;
        private double m_dFrictionLossToEndOfPipe;
        private IList<PipeSectionResults> m_PipeSectionResults;    // convert to list
        private PumpResults m_PumpResults;
        private EnergyResults m_EnergyResults;

        public ProjectResults()
        {
            m_PipeSectionResults = new List<PipeSectionResults>();
            m_PumpResults = new PumpResults(this);
            m_EnergyResults = new EnergyResults(this);
        }

        public double TotalLength
        {
            get { return m_dTotalLength; }
            set { m_dTotalLength = value; }
        }

        public double HighPointElevation
        {
            get { return m_dHighPointElevation; }
            set { m_dHighPointElevation = value; }
        }

        public double DischargeElevation
        {
            get { return m_dDischargeElevation; }
            set { m_dDischargeElevation = value; }
        }

        public double MaxWaterLevelAtPumpStation
        {
            get { return m_dMaxPumpStationWaterElevation; }
            set { m_dMaxPumpStationWaterElevation = value; }
        }

        public double FrictionLossToHighPoint
        {
            get { return m_dFrictionLossToHighPoint; }
            set { m_dFrictionLossToHighPoint = value; }
        }

        public double FrictionLossToEndOfPipe
        {
            get { return m_dFrictionLossToEndOfPipe; }
            set { m_dFrictionLossToEndOfPipe = value; }
        }

        public double StaticHead
        {
            get { return m_dDischargeElevation - m_dMaxPumpStationWaterElevation; }
        }

        public double Tdh
        {
            get { return this.StaticHead + this.FrictionLossToEndOfPipe; }
        }

        public IList<PipeSectionResults> PipeSectionList
        {
            get { return m_PipeSectionResults; }
            set { m_PipeSectionResults = value; }
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
