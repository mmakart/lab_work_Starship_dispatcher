using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StarshipDispatcher.Tests.TestDataGenerators
{
    public class DispatcherTestsDataGenerator : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>
        {
            new object[]
            {
                new DispatcherData(
                    new List<Planet>() {
                        new Planet("Mercury", 0.17, -0.34, 200.0), // 1.132 from Earth
                        new Planet("Venus", 0.6, 0.4, 150.0),      // 0.283 from Earth
                        new Planet("Earth", 0.8, 0.6, 0.0),
                        new Planet("Mars", -1.0, 1.14, 50.0),      // 1.880 from Earth
                        new Planet("Jupiter", 5.1, -0.1, 250.0),   // 4.357 from Earth
                    },
                    // Each starship is needed to satisfy the need for resources
                    new List<Starship>() {
                        new Starship("testship7", 5.2, 100),
                        new Starship("testship9", 6.7, 100),
                        new Starship("testship2", 1.4, 80),
                        new Starship("testship8", 6.4, 100),
                        new Starship("testship1", 1.4, 40),
                        new Starship("testship4", 2.9, 60),
                        new Starship("testship3", 1.4, 90),
                        new Starship("testship6", 3.5, 70),
                        new Starship("testship5", 3.7, 100),
                    }
                )
            },
            new object[]
            {
                new DispatcherData(
                    new List<Planet>() {
                        new Planet("Mercury", 0.17, -0.34, 200.0), // 1.132 from Earth
                        new Planet("Venus", 0.6, 0.4, 150.0),      // 0.283 from Earth
                        new Planet("Earth", 0.8, 0.6, 0.0)
                    },
                    // Each starship is needed to satisfy the need for resources
                    new List<Starship>() {
                        new Starship("testship1", 5.2, 200),
                        new Starship("testship2", 6.7, 100)
                    }
                ),
            }
        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
