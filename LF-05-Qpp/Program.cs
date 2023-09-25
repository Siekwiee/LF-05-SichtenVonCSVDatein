// See https://aka.ms/new-console-template for more information
using CO2_Daten_Analyse; // Import der DataCaclulation.cs Datei für Zusammenarbeit

internal class Program // Klassen initialisierung
{
    private static void Main(string[] args) //Private standart Funktion welche jedes programm bestitzt (Privat mein nich zugänglich für außerhalb der Class)
    {
        Console.WriteLine("Analyzing Weather data!"); //Einfache Ausgabe von Text

        DataCalculation calc = new DataCalculation(); //Erstellen einer lokalen Variable
        calc.Calculation(); //Ausführen der Funktion aus DataCalculation.cs
    }
}