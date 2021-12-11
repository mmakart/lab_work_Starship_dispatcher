using System;
using Xunit;
using StarshipDispatcher;

namespace StarshipDispatcher.Tests
{
    public class PlanetTests
    {
        [Theory]
        [InlineData(0.0, 0.0, 1.0, 1.0, 1.41421)]
        [InlineData(0.0, 0.0, 2.0, 3.0, 3.60555)]
        public void CalculatedDistance_IsCorrect(double x1, double y1, double x2, double y2, double expectedDistance)
        {
            // arrange
            var planet1 = new Planet("p1", x1, y1, 0);
            var planet2 = new Planet("p2", x2, y2, 0);
            // act
            var actualDistance = planet1.DistanceTo(planet2);
            // assert
            Assert.True( Math.Abs(actualDistance - expectedDistance) <= 0.00001 );
        }
    }
}
