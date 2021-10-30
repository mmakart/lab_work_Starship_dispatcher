using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using StarshipDispatcher.Interfaces;


namespace StarshipDispatcher
{
    public class Parser
    {
        private IUnitCalculator UnitCalculator;

        public Parser(IUnitCalculator unitCalculator)
        {
            UnitCalculator = unitCalculator;
        }
        // TODO rename to Parse
        public DispatcherData ParsePlanets(string filename)
        {
            var serializer = new XmlSerializer(typeof(DispatcherData));
            using (var inputStream = new FileStream(filename, FileMode.Open)) {
                var result = serializer.Deserialize(inputStream) as DispatcherData;
                return result;
            }
        }
    }
}
