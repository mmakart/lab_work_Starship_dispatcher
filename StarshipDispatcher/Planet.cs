using System;

namespace StarshipDispatcher
{
    public class Planet
    {
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double ResourceNeed { get; set; }
        public Planet() {}

        public Planet(string name, double x, double y, double resourceNeed)
        {
            Name = name;
            X = x;
            Y = y;
            ResourceNeed = resourceNeed;
        }
    }
}
