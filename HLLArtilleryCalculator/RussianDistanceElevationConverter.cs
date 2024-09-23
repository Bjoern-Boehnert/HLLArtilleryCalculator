namespace HLLArtilleryCalculator
{
    class RussianDistanceElevationConverter : IDistanceElevationConverter
    {
        private const decimal A = 1120m;
        private const decimal B = 21.33m;
        private const decimal L = 100m;

        public int ConvertDistanceToElevation(int  distance)
        {
            return Convert.ToInt32(A - (((distance / L) - 1) * B));
        }
    }
}
