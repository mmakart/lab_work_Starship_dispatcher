using System;

namespace StarshipDispatcher
{
    public class Departure
    {
        public Starship Starship { get; set; }
        public Planet Planet { get; set; }
        public int TransportedWeight
        {
            get => Starship.Tonnage;
            set => Starship.Tonnage = value;
        }
        public Departure() { }
        public Departure(Starship starship, Planet planet)
        {
            Starship = starship;
            Planet = planet;
        }
    }
}
