using System;
using System.Collections.Generic;
using System.Text;

namespace xml_parser_test
{
    public class xmlWorker
    {
        public void WriteContent(string outputFile, string wantedValue)
        {
            File.WriteAllText(outputFile, wantedValue);
        }

        // Andra xml-relaterade metoder kan läggas till här för att hålla koden organiserad och modulär.
    }
}
