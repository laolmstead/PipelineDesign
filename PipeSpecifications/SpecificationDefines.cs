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

    public static class HazenWilliamsCoefficient
    {
        public static int Hdpe = 150;
        public static int SteelWeldedSeamless = 140;
        public static int DuctileIron = 130;
        public static int Copper = 140;
        public static int Brass = 130;
    }

    public static class FluidDensity
    {
        public static double Water = 62.4;
    }
}
