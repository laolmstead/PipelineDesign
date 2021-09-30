﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultsApi
{
    public class PipeCrossSectionResults
    {
        private double m_dNominalDiameter;
        private double m_dInnerDiameter;
        private double m_dOuterDiameter;
        private double m_dPressureRating;
        private int m_iHwCoefficient;
        private double m_dCostPerFt;

        public PipeCrossSectionResults()
        {

        }

        public double NominalDiameter
        {
            get { return m_dNominalDiameter; }
            set { m_dNominalDiameter = value; }
        }

        public double InnerDiameter
        {
            get { return m_dInnerDiameter; }
            set { m_dInnerDiameter = value; }
        }

        public double OuterDiameter
        {
            get { return m_dOuterDiameter; }
            set { m_dOuterDiameter = value; }
        }

        public double PressureRating
        {
            get { return m_dPressureRating; }
            set { m_dPressureRating = value; }
        }

        public int HwCoefficient
        {
            get { return m_iHwCoefficient; }
            set { m_iHwCoefficient = value; }
        }

        public double CostPerLinearFt
        {
            get { return m_dCostPerFt; }
            set { m_dCostPerFt = value; }
        }
    }
}
