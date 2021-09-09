using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specifications
{
    public enum HdpePipeType
    {
        IronPipeSize,
        DuctileIronPipeSize
    }

    public enum PipeHeadLossType
    {
        PipeSection,
        PipeEntrance
    }

    public static class HazenWilliamsCoefficient
    {
        public static int Hdpe = 150;
        public static int SteelWeldedSeamless = 140;
        public static int DuctileIron = 130;
        public static int Copper = 140;
        public static int Brass = 130;
    }

    public static class FittingLossCoefficient
    {
        public static int MoldedElbow90Degree = 30;
        public static int MoldedElbow45Degree = 16;
        public static int FabricatedElbow90Degree = 24;
        public static int FabricatedElbow45Degree = 12;
        public static int EqualOutletTeeRunBranch = 60;
        public static int EqualOutletTeeRunRun = 20;
        public static int ConvGlobeValveFullOpen = 350;
        public static int ConvAngleValveFullOpen = 180;
        public static int ConvWedgeGateValveFullOpen = 15;
        public static int ButterflyValveFullOpen = 40;
        public static int ConvSwingCheckValve = 100;
    }

    public static class FluidDensity
    {
        public static double Water = 62.4;
    }
}
