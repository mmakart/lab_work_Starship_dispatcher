using System;
using System.IO;
using System.Linq;
using Xunit;
using Moq;

namespace StarshipDispatcher.Tests
{
    public class ParserTests
    {
        [Fact]
        public void ReadPlanets_Success()
        {
            // arrange + act
            var filename = Path.Combine("TestData", "input.xml");
            var result = Parser.ParsePlanets(filename);
            // assert
            Assert.NotNull(result?.Planets?.FirstOrDefault(o => o.Name == "Earth"));
        }
    }
}