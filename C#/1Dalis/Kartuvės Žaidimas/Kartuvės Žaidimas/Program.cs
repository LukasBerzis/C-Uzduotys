using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

           Dictionary<int, string> Zodynas = new Dictionary<int, string>();
           Zodynas.Add(1, "island");
           Zodynas.Add(2, "sandwich");
           Zodynas.Add(3, "offensive");
           Zodynas.Add(4, "motif");
           Zodynas.Add(5, "clothes");
           Zodynas.Add(6, "parade");
           Zodynas.Add(7, "chauvinist");
           Zodynas.Add(8, "width");
           Zodynas.Add(9, "quarter");
           Zodynas.Add(10, "emergency");

           int HealthPoints = 7;      

           string ChoosenWord = Zodynas.ElementAt(rnd.Next(Zodynas.Count)).Value;

            HashSet<char> guessedLetters = new HashSet<char>();

            Console.WriteLine("------ Kartuves ------");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(string.Join(" ", ChoosenWord.Select(c => c == ' ' ? " " : "_")));
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            while (HealthPoints > 0)
            {
                string displayWord = string.Join(" ", ChoosenWord.Select(c => guessedLetters.Contains(c) ? c : '_'));


                Console.WriteLine("\n" + displayWord);
                Console.WriteLine($"HP - {HealthPoints} ");

                if (!displayWord.Contains('_'))
                {
                    Console.WriteLine("Laimejai!");
                    break;
                }

                Console.Write("Spekite raide: ");
                string spejimas = Console.ReadLine();

                while (String.IsNullOrWhiteSpace(spejimas) || spejimas.Length != 1 || !char.IsLetter(spejimas[0]))
                {
                    Console.Write("Galite ivesti tik viena raide: ");
                    spejimas = Console.ReadLine();
                }

                char letter = char.ToLower(spejimas[0]);

                if (guessedLetters.Contains(letter))
                {
                    Console.WriteLine("Si raide jau spejote!");
                    continue;
                }

                guessedLetters.Add(letter);

                if (ChoosenWord.Contains(letter))
                {
                    Console.WriteLine("ATSPEJAI!");
                }
                else
                {
                    Console.WriteLine("Neteisingai!");
                    HealthPoints--;
                }             

            }

            if (HealthPoints == 0)
            {
                Console.WriteLine($"ZAIDIMAS BAIGTAS! Zodis buvo: {ChoosenWord}");
            }

        }
    }
}