namespace HLLArtilleryCalculator
{
    class BritishDistanceElevationConverter : IDistanceElevationConverter
    {
        private const decimal M = -0.1773m;
        private const decimal B = 550.69m;

        public int ConvertDistanceToElevation(int distance)
        {
            return Convert.ToInt32( M * distance + B);
        }
    }
}
