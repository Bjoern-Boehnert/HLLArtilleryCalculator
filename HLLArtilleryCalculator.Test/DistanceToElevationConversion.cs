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
            var tuples = new Tuple<decimal, decimal>[]
            {
                // Values taken from in-game UI
                Tuple.Create(1600m, 622m),
                Tuple.Create(1500m, 646m),
                Tuple.Create(1400m, 670m),
                Tuple.Create(1000m, 764m),
                Tuple.Create(900m, 788m),
                Tuple.Create(600m, 859m),
                Tuple.Create(500m, 883m),
                Tuple.Create(200m, 954m),
                Tuple.Create(100m, 978m),
            };

            IDistanceElevationConverter converter = new DistanceElevationConverter();

            foreach (var tuple in tuples)
            {
                Assert.Equal(tuple.Item2, Math.Round(converter.ConvertDistanceToElevation(tuple.Item1)));
            }
        }

        [Fact]
        public void TestRussiaDistanceToElevationConversion()
        {
            var tuples = new Tuple<decimal, decimal>[]
            {
                // Values taken from in-game UI
                Tuple.Create(1600m, 800m),
                Tuple.Create(1500m, 821m),
                Tuple.Create(1400m, 843m),
                Tuple.Create(1000m, 928m),
                Tuple.Create(900m, 949m),
                Tuple.Create(600m, 1013m),
                Tuple.Create(500m, 1035m),
                Tuple.Create(200m, 1099m),
                Tuple.Create(100m, 1120m),
            };

            IDistanceElevationConverter converter = new RussianDistanceElevationConverter();

            foreach (var tuple in tuples)
            {
                Assert.Equal(tuple.Item2, Math.Round(converter.ConvertDistanceToElevation(tuple.Item1)));
            }
        }

        [Fact]
        public void TestBritishDistanceToElevationConversion()
        {
            var tuples = new Tuple<decimal, decimal>[]
            {
                // Values taken from in-game UI
                Tuple.Create(1600m, 267m),
                Tuple.Create(1500m, 285m),
                Tuple.Create(1400m, 302m),
                Tuple.Create(1000m, 373m),
                Tuple.Create(900m, 391m),
                Tuple.Create(600m, 444m),
                Tuple.Create(500m, 462m),
                Tuple.Create(200m, 515m),
                Tuple.Create(100m, 533m),
            };

            IDistanceElevationConverter converter = new BritishDistanceElevationConverter();

            foreach (var tuple in tuples)
            {
                Assert.Equal(tuple.Item2, Math.Round(converter.ConvertDistanceToElevation(tuple.Item1)));
            }
        }
    }
}
