using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace StarshipDispatcher
{
    public static class Parser
    {
        // TODO rename to Parse
        public static DispatcherData ParsePlanets(string filename)
        {
            var serializer = new XmlSerializer(typeof(DispatcherData));
            using (var inputStream = new FileStream(filename, FileMode.Open)) {
                var result = serializer.Deserialize(inputStream) as DispatcherData;
                return result;
            }
        }
    }
}
