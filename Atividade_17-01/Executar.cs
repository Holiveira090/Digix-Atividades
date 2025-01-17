using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_17_01
{
    public class Executar
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o tamnho N da matriz: ");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o tamanho M da matriz");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = random.Next(100);
                }
            }

            string filePath = "Resultados.csv";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                int escolha = 0;
                ExibirMatriz(matriz, writer);
                System.Console.Write("Escolha uma opção: \n1 - Calcular a soma de uma linha da matriz.\n2 - Calcular a soma de uma coluna da matriz.\n3 - Transpor a matriz.\n4 - Sair.\nEscolha: ");
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        CalcularSomaLinha(matriz, writer);
                        break;
                    case 2:
                        CalcularSomaColuna(matriz, writer);
                        break;
                    case 3:
                        TransporMatriz(matriz, writer);
                        break;
                    default:
                        System.Console.WriteLine("Erro: Opção inválida.");
                        break;
                }
            }
        }

        public static void ExibirMatriz(int[,] matriz, StreamWriter writer)
        {
            writer.WriteLine("Matriz aleatória:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    writer.Write(matriz[i, j] + " ");
                }
                writer.WriteLine();
            }
            writer.WriteLine();
        }

        public static void CalcularSomaLinha(int[,] matriz, StreamWriter writer)
        {
            writer.WriteLine("Somas das linhas:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                int soma = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    soma += matriz[i, j];
                }
                writer.WriteLine($"Soma da linha {i + 1}: {soma}");
            }
        }

        public static void CalcularSomaColuna(int[,] matriz, StreamWriter writer)
        {
            writer.WriteLine("\nSomas das colunas:");
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                int soma = 0;
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    soma += matriz[j, i];
                }
                writer.WriteLine($"Soma da coluna {i + 1}: {soma}");
            }
        }

        public static void TransporMatriz(int[,] matriz, StreamWriter writer)
        {
            writer.WriteLine("\nMatriz transposta:");
            for (int i = 0; i < matriz.GetLength(1); i++) // Troca de linhas por colunas
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    writer.Write(matriz[j, i] + " ");
                }
                writer.WriteLine();
            }
        }
    }
}