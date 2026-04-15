using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace xml_parser_test
{
    public class xmlWorker
    {

        public XDocument LoadXml(string path)
        {
            return XDocument.Load(path);
            
        }

        public string? GetTargetedValue(XDocument xml, string element, int id)
        {
            // LINQ query FirstOrDefailt för att filtrera på attributet "id" och jämföra det med strängen "42014". Resultatet sparas i variabeln "wantedValue".
            //OBS - attributets värdet castas om till int (från sträng) för att kunna jämföras med talet 42014 som är av typen int.

            var wantedElement = xml.Descendants(element).FirstOrDefault(x => (int?)x.Attribute("id") == id);

            var wantedValue = (string?)wantedElement?.Element("target")?.Value;
            return wantedValue;
        }
        public void WriteContent(string outputFile, string wantedValue)
        {
            File.WriteAllText(outputFile, wantedValue);
        }

        // Andra xml-relaterade metoder kan läggas till här för att hålla koden organiserad och modulär.
    }
}
