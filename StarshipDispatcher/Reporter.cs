using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace StarshipDispatcher
{
    public static class Reporter
    {
        public static void Send(List<Departure> schecule, string outputFilename)
        {
            var serializer = new XmlSerializer(typeof(List<Departure>));
            using (var outputFile = new FileStream(outputFilename, FileMode.OpenOrCreate))
            {
                serializer.Serialize(outputFile, schecule);
            }
        }
    }
}
