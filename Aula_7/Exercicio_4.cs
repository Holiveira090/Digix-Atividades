// using System;

// namespace Exercicio_4
// {
//     class Exercicio_4
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Digite o tamanho da matriz quadrada (n): ");
//             int n = int.Parse(Console.ReadLine());

//             int[,] matriz = new int[n, n];
//             int somaDiagonalPrincipal = 0;
//             int somaDiagonalSecundaria = 0;

//             // Leitura dos elementos da matriz
//             Console.WriteLine("Digite os elementos da matriz:");
//             for (int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     Console.Write($"Elemento [{i + 1}, {j + 1}]: ");
//                     matriz[i, j] = int.Parse(Console.ReadLine());
//                 }
//             }

//             // Cálculo das somas das diagonais
//             for (int i = 0; i < n; i++)
//             {
//                 somaDiagonalPrincipal += matriz[i, i];
//                 somaDiagonalSecundaria += matriz[i, n - 1 - i];  
//             }

//             // Exibição dos resultados
//             Console.WriteLine($"Soma da diagonal principal: {somaDiagonalPrincipal}");
//             Console.WriteLine($"Soma da diagonal secundária: {somaDiagonalSecundaria}");
//         }
//     }
// }