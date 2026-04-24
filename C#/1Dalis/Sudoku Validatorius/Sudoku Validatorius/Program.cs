using System;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static bool EilutesValidacia(int[,]arr)
        {

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                HashSet<int> Unique = new HashSet<int>();

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int value = arr[i, j];
                    if (value != 0)
                    {
                        Unique.Add(value);
                    }
                }

                if (Unique.Count != 9)
                {
                    Console.WriteLine($"Neteisinga eilute: {i}");
                    return false;
                }

                Console.WriteLine("Eilutes teisingos");
            }

            return true;
        }

        static bool StulpelioValidacia(int[,]arr)
        {
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                HashSet<int> Unique = new HashSet<int>();

                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    int value = arr[j, i];
                    if (value != 0)
                    {
                        Unique.Add(value);
                    }
                }

                if (Unique.Count != 9)
                {
                    Console.WriteLine($"Neteisingas stulpelis: {i}");
                    return true;
                }
                
            }
            Console.WriteLine("Stulpeliai teisingi");
            return false;
        }

        static bool PotinklioValidacija(int[,]arr)
        {
            for (int bowRow = 0; bowRow < 3; bowRow++)
            {
                for (int boxCol = 0; boxCol < 3; boxCol++)
                {
                    HashSet<int> unique = new HashSet<int>();

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            int value = arr[bowRow * 3 + i, boxCol * 3 + j];

                            if (value != 0)
                            {
                                unique.Add(value);
                            }
                        }
                    }

                    if(unique.Count != 9)
                    {
                        Console.WriteLine($"Neteisingas 3x3 blokas: ({bowRow}, {boxCol})");
                        return false;
                    }
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            int[,] sudoku = new int[9,9]; //rows and collumns

            using (StreamReader sr = new StreamReader("sudoku.txt"))
            {
                string line;
                int row = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] split = line.Split(" ");
                    for (int col = 0; col  < split.Length; col++)
                    {
                        sudoku[row, col] = int.Parse(split[col]);
                    }

                    row++;
                    Console.WriteLine(line);
                }


            }

            if (EilutesValidacia(sudoku) && StulpelioValidacia(sudoku) && PotinklioValidacija(sudoku))
            {  
                        Console.WriteLine("Teisingas");
            }
            else
            {
                Console.WriteLine("Neteisingas");
            }
        }
    }
}