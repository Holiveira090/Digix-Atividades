// using System;

// namespace Exercicio_2
// {
//     class Exercicio_2
//     {
//         // Define o delegate
//         public delegate int Soma(int[,] matriz);

//         // Método que calcula a soma de cada linha da matriz e retorna a soma total
//         static int CalcularSoma(int[,] matriz)
//         {
//             int somaTotal = 0;

//             // Itera sobre as linhas da matriz
//             for (int i = 0; i < matriz.GetLength(0); i++)
//             {
//                 int somaLinha = 0;

//                 // Itera sobre as colunas da linha atual
//                 for (int j = 0; j < matriz.GetLength(1); j++)
//                 {
//                     somaLinha += matriz[i, j];
//                 }

//                 Console.WriteLine($"A soma da {i + 1}° linha é: {somaLinha}");
//                 somaTotal += somaLinha; // Adiciona a soma da linha ao total
//             }

//             return somaTotal;
//         }

//         static void Main(string[] args)
//         {
//             // Declara a matriz
//             int[,] matriz = {
//                 { 1, 2, 3, 4},
//                 { 5, 6, 7, 8},
//                 { 9, 10, 11, 12},
//                 {13, 14, 15, 16}
//             };

//             // Usa o delegate para referenciar o método CalcularSoma
//             Soma calcularSoma = CalcularSoma;
//             int resultado = calcularSoma(matriz);

//             Console.WriteLine($"O resultado da soma da matriz é: {resultado}");
//         }
//     }
// }
