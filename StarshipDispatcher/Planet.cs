using System;

namespace StarshipDispatcher
{
    public class Planet
    {
        // [FromConstructor]
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public Planet() {}

        public Planet(string name, double x, double y)
        {
            Name = name;
            X = x;
            Y = y;
        }
    }
}
