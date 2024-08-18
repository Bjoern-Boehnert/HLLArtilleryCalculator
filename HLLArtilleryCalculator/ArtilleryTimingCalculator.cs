using System;

namespace HLLArtilleryCalculator
{
    class ArtilleryTimingCalculator
    {
        private const double TRAVEL_TIME_IN_SECONDS = 24.5d;

        public DateTime PredictHitTime(DateTime firedAt)
        {
            return firedAt.AddSeconds(TRAVEL_TIME_IN_SECONDS);
        }
    }
}
