﻿namespace ExercicioMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] value = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(value[j]);
                }                
            }

            Console.WriteLine("Main diagonal:");
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{ matriz[i, i]} ");
            }
            Console.WriteLine();

            int count = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (matriz[i,j] < 0)
                        count++;                    
                }                
            }
            Console.WriteLine($"Negative numbers: {count}");

            var x = 10;
            var u = 10.0;
        }
    }
}