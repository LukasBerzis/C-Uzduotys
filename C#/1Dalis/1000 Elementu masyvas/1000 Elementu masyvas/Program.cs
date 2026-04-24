using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = new int[1000];
            double [] groups = new double[10];

            Random rnd = new Random();

            for (int i = 0; i < masyvas.Length; i++)
            {
                masyvas[i] = rnd.Next(1, 101);
                //Console.Write($"{masyvas[i]} ");

                if (masyvas[i] >= 1 && masyvas[i] <= 10)
                {
                    groups[0]++;
                }
                else if (masyvas[i] >= 11 && masyvas[i] <= 20)
                {
                    groups[1]++;
                }
                else if (masyvas[i] >= 21 && masyvas[i] <= 30)
                {
                    groups[2]++;
                }
                else if (masyvas[i] >= 31 && masyvas[i] <= 40)
                {
                    groups[3]++;
                }
                else if (masyvas[i] >= 41 && masyvas[i] <= 50)
                {
                    groups[4]++;
                }
                else if (masyvas[i] >= 51 && masyvas[i] <= 60)
                {
                    groups[5]++;
                }
                else if (masyvas[i] >= 61 && masyvas[i] <= 70)
                {
                    groups[6]++;
                }
                else if (masyvas[i] >= 71 && masyvas[i] <= 80)
                {
                    groups[7]++;
                }
                else if (masyvas[i] >= 81 && masyvas[i] <= 90)
                {
                    groups[8]++;
                }
                else 
                {
                    groups[9]++;
                } 
            }

            for (int i = 0; i < groups.Length; i++)
            {
                int nuo = i * 10 + 1;
                int iki = (i + 1) * 10;

                double procent = groups[i] / 1000 * 100;
                Console.WriteLine($"{nuo}-{iki} -> {Math.Round(procent, 0)} %");
            }
        }
    }
}