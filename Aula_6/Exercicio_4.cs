using System;

namespace Exercico_4
{
    class Exercico_4
    {
        static void Main(string[] args)
        {  
            int[,] matriz = new int[4, 4] 
            {
                { 1, 2, 3, 4}, 
                { 5, 6, 7, 8}, 
                { 9, 10, 11, 12}, 
                { 13, 14, 15, 16}
            };

            int somaDiagonalPrincipal = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                somaDiagonalPrincipal += matriz[i, i];
            }

            Console.WriteLine($"A soma dos elementos da diagonal principal é: {somaDiagonalPrincipal}");
        }
    }
}
