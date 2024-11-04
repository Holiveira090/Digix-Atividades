using System;

namespace Exercicio_5
{
    class Exercicio_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho da matriz quadrada (n): ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            // Leitura e atribuição dos elementos da matriz
            Console.WriteLine("Digite os elementos da matriz:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Elemento [{i + 1}, {j + 1}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Exibição da matriz no formato correto
            Console.WriteLine("\nMatriz:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine(); 
            }
            
        }
    }
}
