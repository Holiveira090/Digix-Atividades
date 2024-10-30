// using System;

// namespace Exemplo
// {
//     class Exemplo
//     {
//         static void Main(string[] args)
//         {  
//             // 1. Ler um vetor com 10 inteiros e mostrar os valores
//             // da ordem direta e inversa em que foram lidos.
//             int[] vetor = new int[10];
//             Random random = new Random();

//             // Preenchendo o vetor com números aleatórios
//             for (int i = 0; i < 10; i++)
//             {
//                 vetor[i] = random.Next(1, 100);
//             }

//             // Mostrando a ordem direta
//             Console.Write("Ordem direta: ");
//             for (int i = 0; i < 10; i++)
//             {
//                 Console.Write($"{vetor[i]} ");
//             }
//             Console.WriteLine();

//             // Mostrando a ordem inversa
//             Console.Write("Ordem inversa: ");
//             for (int i = 9; i >= 0; i--)
//             {
//                 Console.Write($"{vetor[i]} ");
//             }
//             Console.WriteLine();
//         }
//     }
// }
