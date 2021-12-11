using System;
using System.Collections.Generic;
using System.Linq;
using StarshipDispatcher;

namespace StarshipDispatcher
{
    public static class Dispatcher
    {
        public static IEnumerable<Departure> CompileSchedule(DispatcherData data)
        {
            var schedule = new List<Departure>();
            var earth = data.Planets.FirstOrDefault(o => o.Name == "Earth");

            // for checking out the planets for "do we need to send one more spaceship"
            // and keeping initial planets state immutable
            var tempResouceNeeds = new Dictionary<Planet, double>();
            foreach (var planet in data.Planets)
            {
                tempResouceNeeds.Add(planet, planet.ResourceNeed);
            }

            foreach (var planet in data.Planets.Where(o => o.Name != "Earth"))
            {
                while (tempResouceNeeds[planet] > 0)
                {
                    foreach (var starship in data.Starships)
                    {
                        // twice because to the planet and back to Earth
                        var neededPath = 2 * earth.DistanceTo(planet);
                        var maxPossiblePath = starship.FlightRange;

                        bool isPlanetNeed = tempResouceNeeds[planet] >= 0;
                        bool canReachPlanet = neededPath <= maxPossiblePath;
                    
                        if (isPlanetNeed && canReachPlanet)
                        {
                            schedule.Add(new Departure(starship, planet));
                            tempResouceNeeds[planet] -= starship.Tonnage;
                        }
                    }
                }
            }
            return schedule;
        }
    }
}
