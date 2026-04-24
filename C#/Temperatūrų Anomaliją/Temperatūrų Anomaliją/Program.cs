using System;

namespace Temperatūros_anomalija
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            double[] Temperature = new double[30];

            double avg = 0;

            for (int i = 0; i < Temperature.Length; i++)
            {
                Temperature[i] = Math.Round(random.NextDouble() * (36 - (-10)) + (-10), 1);
            }

            avg = Math.Round(Temperature.Average(), 1);

            Console.WriteLine($"Temperaturos Vidurkis: {avg} C");

            Console.WriteLine("Pradinis masyvas: ");
            foreach (var item in Temperature)
            {
                Console.Write($" {item} C ");
            }

            int diena = 1;
            Console.WriteLine("Temperaturos anomalijos: ");
            foreach (var item in Temperature)
            {
                int i = 1;
                double temp = Math.Round(item, 0);
                if (Math.Abs(temp - avg) >= 8)
                {
                    Console.WriteLine($"Temperaturos anomalijs - {item} C  {diena} diena");
                }

                diena++;
            }


        }
    }
}