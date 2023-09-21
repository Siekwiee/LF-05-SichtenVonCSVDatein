// See https://aka.ms/new-console-template for more information
using CO2_Daten_Analyse;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Analyzing Weather data!");

        DataCalculation calc = new DataCalculation();
        calc.Calculation();
    }
}