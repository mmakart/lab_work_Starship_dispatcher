using System.Collections.Generic;

namespace StarshipDispatcher
{
    public class DispatcherData
    {
        public List<Planet> Planets { get; set; }
        public List<Starship> Starships { get; set; }

        public DispatcherData() {}

        public DispatcherData(List<Planet> planets, List<Starship> starships)
        {
            Planets = planets;
            Starships = starships;
        }
    }
}
