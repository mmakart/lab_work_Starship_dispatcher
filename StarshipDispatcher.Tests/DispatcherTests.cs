using System.Linq;
using Xunit;
using StarshipDispatcher.Tests.TestDataGenerators;

namespace StarshipDispatcher.Tests
{
    public class DispatcherTests
    {
        [Theory]
        [ClassData(typeof(DispatcherTestsDataGenerator))]
        public void IfEnoughSpaceships_AllPlanetsAreProvided(DispatcherData data)
        {
            // arrange, act
            var schedule = Dispatcher.CompileSchedule(data);
            foreach (var departure in schedule)
            {
                var amount = departure.TransportedWeight;
                departure.Planet.ReceiveResource(departure.TransportedWeight);
            }
            // assert
            Assert.True(schedule.All<Departure>(o => o.Planet.ResourceNeed == 0));
        }
    }
}
