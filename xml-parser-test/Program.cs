using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using xml_parser_test;

// Skapa en instans av klassen xmlWorker för att kunna använda dess metoder.
var xmlWorker = new xmlWorker();

// Ladda och spara innehållet i XML-filen "gentext.xml" i en variabel av typen XDocument (C# XML-representation)
var xmlFile = xmlWorker.LoadXml("gentext.xml");

// Deklarera en variabel för outfil för större flexibilitet och för att undvika hårdkodning av filnamn samt eftersökta id (i metoden WriteContent).
var outputFile = "output.txt";

//Deklarera variabler för det element som ska lokaliseras samt id för mer flexibilitet och undvikande av hårdkodning.
//Strikt typade variabler för att undvika fel och överstämma med xmlWorkers metodparams.
string targetedElement = "trans-unit";
int targetedId = 42014;

var value = xmlWorker.GetTargetedValue(xmlFile, targetedElement, targetedId);

if (value != null)
{
    xmlWorker.WriteContent(outputFile, value);
}
else
{
    Console.WriteLine($"Elementet {targetedElement} med id {targetedId} hittades inte.");
}
