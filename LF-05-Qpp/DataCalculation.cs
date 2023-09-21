using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CO2_Daten_Analyse
{
    class DataCalculation
    {
        public void Calculation()
        {
            string csvFilePath = @"C:\Users\Jannik.Wiest\Documents\VSProjects\LF-05-SichtenVonCSVDatein\LF-05-Qpp\daten.csv"; // Replace with the actual file path

            List<Tuple<DateTime,double>> temperatures = new List<Tuple<DateTime,double>>();
            double averageTemp = 0.0;
            
            // Read and parse the CSV file manually
            using (var reader = new StreamReader(csvFilePath))
            {
                // Skip the first four lines (header and format information)
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();

                int tempCount = 0;
                double tempSum = 0.0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(',');

                    DateTime time = DateTime.Parse(values[0]);
                    double temperature = double.Parse(values[1], CultureInfo.InvariantCulture);
                    temperatures.Add(new Tuple<DateTime, double>(time,temperature));
                    tempSum+= temperature;
                    tempCount++;
                }

                averageTemp = tempSum / tempCount; 
            }
            foreach (var temperature in temperatures)
            {
                if(temperature.Item2 > averageTemp +5.0){
                      Console.WriteLine($"Temperature above 7°C of Average Temp at {temperature.Item1} ");
                }
            }
            
            Console.WriteLine($"Average Temperatur is {averageTemp}.");
            Console.WriteLine("Finished analyzing Weather data!");
        }
    }
}