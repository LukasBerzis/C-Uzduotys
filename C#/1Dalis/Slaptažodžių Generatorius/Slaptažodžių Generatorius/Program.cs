using System;
using System.Text;

namespace Slaptažodžių_Generatorius
{
    class Program
    {   
        static bool TaipArNe(string uzklausa)
        {
            while (true)
            {
                Console.Write(uzklausa);
                string? ats = Console.ReadLine()?.ToUpper();

                if (ats == "Y") return true;
                if (ats == "N") return false;

                Console.WriteLine("Įveskite tik Y arba N!");
            }
        }

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Random random = new Random();

            Console.Write("Iveksite passwordo ilgi: ");
            int PassIlgis = Convert.ToInt32(Console.ReadLine());

            bool didziosios = TaipArNe("Naudoti DIDŽIĄSIAS raides? (Y / N): ");

            bool mazosios = TaipArNe("Ar naudoti Mazasias raidės? (Y / N) :");

            bool simboliai = TaipArNe("Ar naudoti simbolius? (Y / N) :");

            bool skaiciai = TaipArNe("Ar naudoti skaicius? (Y / N) :");

            for (int i = 0; i < PassIlgis; i++)
            {
                int WhichCharacter = random.Next(0, 3);
                if (WhichCharacter == 0)
                {
                    Char raide;
                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    raide = Convert.ToChar(shift + 65);

                    if (didziosios && mazosios)
                    {
                        if (random.Next(0, 2) == 1)
                            raide = char.ToLower(raide);
                    }
                    else if (!didziosios && mazosios)
                    {
                        raide = char.ToLower(raide);
                    }
                    else if (didziosios && !mazosios)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Pasirink bent viena raidziu tipa!");
                        return;
                    }

                    sb.Append(raide);
                }
                else if (skaiciai == true && WhichCharacter == 1)
                {
                    int number = random.Next(0, 10);
                    sb.Append(number);
                }
                else if (simboliai == true && WhichCharacter == 2)
                {
                    string symbols = "!@#$%^&*()_+-=[]{}|;:,.<>?";
                    char symbol = symbols[random.Next(symbols.Length)];

                    sb.Append(symbol);
                }

            }

            Console.WriteLine(sb.ToString());
        }
    }
}