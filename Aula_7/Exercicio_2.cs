using System;

namespace Exercicio_2
{
    class Exercicio_2
    {
        static void Main(string[] args)
        {
            int[,] matriz = {
                { 1, 2 ,3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 }
            };

            Console.WriteLine("Soma dos elementos de cada linha:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int somaLinha = 0; 

                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    somaLinha += matriz[i, j]; 
                }

                Console.WriteLine($"Soma da linha {i + 1}: {somaLinha}");
            }
        }
    }
}
