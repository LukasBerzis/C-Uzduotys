using System;

namespace KMI_Skaiciuotuvas
{
    class Program
    {
        static double SkaiciuValidacija(string uzklausa)
        {
            double skaicius;

            while (true)
            {
                Console.WriteLine(uzklausa);
                string? ivestis = Console.ReadLine();

                if (double.TryParse(ivestis, out skaicius) && skaicius > 0)
                {
                    return skaicius;
                }

                Console.WriteLine("Klaida: iveskite teigiama skaiciu!");
            }
        }

        static void Main(string[] args)
        { 
            double svoris = SkaiciuValidacija("Iveskite svori (kg):");

            Console.Write("Iveskite ugi(cm): ");
            double ugis = SkaiciuValidacija("Iveskite ugi(cm): ");

            double KMI = svoris / Math.Pow(ugis / 100.0, 2);

            Console.WriteLine($"Jusu KMI yra : {KMI:F2}");
            if (KMI < 18.5)
                Console.WriteLine("Per mazas svoris");
            else if (KMI < 25)
                Console.WriteLine("Normalus svoris");
            else if (KMI < 30)
                Console.WriteLine("Antsvoris");
            else
                Console.WriteLine("Nutukimas");
        }
    }
}