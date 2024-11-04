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

            // Exibição da matriz original
            Console.WriteLine("\nMatriz Original:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Rotacionando a matriz 90 graus no sentido horário
            int[,] matrizRotacionada = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizRotacionada[j, n - i - 1] = matriz[i, j];
                }
            }

            // Exibição da matriz rotacionada
            Console.WriteLine("\nMatriz Rotacionada 90 graus:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrizRotacionada[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
