using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, int> MokiniuSarasas = new Dictionary<string, int>();

           Console.WriteLine("iveskitem mokinio varda ir balus (Aldona 95)(palikite tuscia kad iseiti): ");

            while (true)
            {
                string Mokinys = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(Mokinys))
                {
                    break;
                }

                string[] split = Mokinys.Split(' ');

                MokiniuSarasas.Add(split[0], Convert.ToInt32(split[1]));
            }


            using (StreamWriter sw = new StreamWriter("students.txt", true) )
            {
                foreach (var item in MokiniuSarasas)
                {
                    sw.WriteLine($"{item.Key}, {item.Value}");
                }
            }

            List<(string vardas, int balas)> list = new List<(string, int)>();

            using (StreamReader sr = new StreamReader("students.txt", true))
            {
                string eilute;

                while ((eilute = sr.ReadLine()) != null)
                {
                    string[] split = eilute.Split(',');

                    string vardas = split[0];
                    int balas = Convert.ToInt32(split[1]);

                    list.Add((vardas, balas));
                }
            }

            var sort = list.OrderByDescending(x => x.balas);

            Console.WriteLine("Surusiuoti mokiniai");

            foreach (var item in sort)
            {
                Console.WriteLine($"{item.vardas} -> {item.balas}");
            }
        }
    }
}