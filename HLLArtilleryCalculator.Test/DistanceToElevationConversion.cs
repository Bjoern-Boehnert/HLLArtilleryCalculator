using System;
using Xunit;
using HLLArtilleryCalculator;

namespace HLLArtilleryCalculator.Tests
{
    public class DistanceToElevationConversion
    {
        [Fact]
        public void TestRegularDistanceToElevationConversion()
        {
            var tuples = new Tuple<int, int>[]
            {
                // Values taken from in-game UI
                Tuple.Create(1600, 622),
                Tuple.Create(1500, 646),
                Tuple.Create(1400, 670),
                Tuple.Create(1000, 764),
                Tuple.Create(900, 788),
                Tuple.Create(600, 859),
                Tuple.Create(500, 883),
                Tuple.Create(200, 954),
                Tuple.Create(100, 978),
            };

            IDistanceElevationConverter converter = new DistanceElevationConverter();

            foreach (var tuple in tuples)
            {
                Assert.Equal(tuple.Item2, converter.ConvertDistanceToElevation(tuple.Item1));
            }
        }

        [Fact]
        public void TestRussiaDistanceToElevationConversion()
        {
            var tuples = new Tuple<int, int>[]
            {
                // Values taken from in-game UI
                Tuple.Create(1600, 800),
                Tuple.Create(1500, 821),
                Tuple.Create(1400, 843),
                Tuple.Create(1000, 928),
                Tuple.Create(900, 949),
                Tuple.Create(600, 1013),
                Tuple.Create(500, 1035),
                Tuple.Create(200, 1099),
                Tuple.Create(100, 1120),
            };

            IDistanceElevationConverter converter = new RussianDistanceElevationConverter();

            foreach (var tuple in tuples)
            {
                Assert.Equal(tuple.Item2,converter.ConvertDistanceToElevation(tuple.Item1));
            }
        }

        [Fact]
        public void TestBritishDistanceToElevationConversion()
        {
            var tuples = new Tuple<int, int>[]
            {
                // Values taken from in-game UI
                Tuple.Create(1600, 267),
                Tuple.Create(1500, 285),
                Tuple.Create(1400, 302),
                Tuple.Create(1000, 373),
                Tuple.Create(900, 391),
                Tuple.Create(600, 444),
                Tuple.Create(500, 462),
                Tuple.Create(200, 515),
                Tuple.Create(100, 533),
            };

            IDistanceElevationConverter converter = new BritishDistanceElevationConverter();

            foreach (var tuple in tuples)
            {
                Assert.Equal(tuple.Item2,converter.ConvertDistanceToElevation(tuple.Item1));
            }
        }
    }
}
