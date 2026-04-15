using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using xml_parser_test;

// Skapa en instans av klassen xmlWorker för att kunna använda dess metoder.
var xmlWorker = new xmlWorker();

// Ladda och spara innehållet i XML-filen "gentext.xml" i en variabel av typen XDocument (C# XML-representation)
var xmlFile = XDocument.Load("gentext.xml");

// Deklarera en variabel för outfil för större flexibilitet och för att undvika hårdkodning av filnamn samt eftersökta id (i metoden WriteContent).
var outputFile = "output.txt";

//Deklarera variabler för det element som ska lokaliseras samt id för mer flexibilitet och undvikande av hårdkodning. 
string targetedElement = "trans-unit";
int targetedId = 42014;

// LINQ query FirstOrDefailt för att filtrera på attributet "id" och jämföra det med strängen "42014". Resultatet sparas i variabeln "wantedValue".
//OBS - attributets värdet castas om till int (från sträng) för att kunna jämföras med talet 42014 som är av typen int.

var wantedElement = xmlFile.Descendants(targetedElement).FirstOrDefault(x => (int)x?.Attribute("id") == targetedId);

var wantedValue = (string)wantedElement?.Element("target")?.Value;



if (wantedValue != null)
{
    xmlWorker.WriteContent(outputFile, wantedValue);
}
else
{
    Console.WriteLine($"Elementet {targetedElement} med id {targetedId} hittades inte.");
}
