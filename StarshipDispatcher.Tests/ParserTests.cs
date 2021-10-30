using System;
using System.IO;
using System.Linq;
using Xunit;
using Moq;
using StarshipDispatcher.Interfaces;

namespace StarshipDispatcher.Tests
{
    public class ParserTests
    {
        [Fact]
        public void ReadPlanets_Success()
        {
            // arrange + act
            var unitCalculatorMock = new Mock<IUnitCalculator>();
            var filename = Path.Combine("TestData", "input.xml");
            var result = new Parser(unitCalculatorMock.Object).ParsePlanets(filename);
            // assert
            Assert.NotNull(result?.Planets?.FirstOrDefault(o => o.Name == "Earth"));
        }
    }
}