using System;

class Program
{
    // Função privada para rotacionar a matriz 90 graus no sentido horário
    private static void RotacionarMatriz90Graus(int[,] matriz, int n)
    {
        // Cria uma nova matriz para armazenar o resultado da rotação
        int[,] matrizRotacionada = new int[n, n];

        // Realiza a rotação da matriz
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrizRotacionada[j, n - 1 - i] = matriz[i, j];
            }
        }

        // Copia a matriz rotacionada de volta para a matriz original
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = matrizRotacionada[i, j];
            }
        }
    }

    // Função pública para exibir a matriz no console
    public static void ExibirMatriz(int[,] matriz, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Digite o tamanho da matriz quadrada (n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];

        // Leitura dos elementos da matriz
        Console.WriteLine("Digite os elementos da matriz:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Elemento [{i + 1}, {j + 1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Exibe a matriz original
        Console.WriteLine("\nMatriz Original:");
        ExibirMatriz(matriz, n);

        // Chama a função para rotacionar a matriz
        RotacionarMatriz90Graus(matriz, n);

        // Exibe a matriz rotacionada
        Console.WriteLine("\nMatriz Rotacionada 90 Graus:");
        ExibirMatriz(matriz, n);
    }
}
