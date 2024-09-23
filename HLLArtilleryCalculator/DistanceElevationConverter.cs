using System.Windows.Forms.VisualStyles;

namespace HLLArtilleryCalculator
{
    class DistanceElevationConverter : IDistanceElevationConverter
    {
        private const decimal A = 1001.465m;
        private const decimal B = -0.2371m;

        public int ConvertDistanceToElevation(int distance)
        {
            return Convert.ToInt32(A + (B * distance));
        }
    }
}
