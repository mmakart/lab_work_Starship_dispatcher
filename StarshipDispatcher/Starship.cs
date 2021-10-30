using System;

namespace StarshipDispatcher
{
    public class Starship
    {
        public string Name { get; set; }
        public double FlightRange { get; set; }
        public int Tonnage { get; set; }

        public Starship() {}

        public Starship(string name, double range, int tonnage)
        {
            Name = name;
            FlightRange = range;
            Tonnage = tonnage;
        }
    }
}
