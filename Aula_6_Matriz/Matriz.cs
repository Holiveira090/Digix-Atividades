// using System;

// namespace Aula_6
// {
//     class Aula_6
//     {
//         static void Main(string[] args)
//         {  
//             // Formas de declarar uma Matriz
//             int[,] matriz1 = new int[2, 2]; // 2 linhas e 2 colunas
//             // Que é
//             // 01
//             // 23
//             int[,] matriz2 = {
//                 { 1, 2 }, // linha 0 tem 1 e 2
//                 { 3, 4 }  // linha 1 tem 3 e 4
//             };

//             // Acessando elementos da matriz
//             Console.WriteLine(matriz2[0, 0]); // 1
//             Console.WriteLine(matriz2[0, 1]); // 2

//             // Percorrendo a matriz
//             Console.WriteLine("Elementos da matriz2:");
//             for (int i = 0; i < matriz2.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matriz2.GetLength(1); j++)
//                 {
//                     Console.WriteLine(matriz2[i, j]);
//                 }
//             }

//             // Somando os elementos da matriz
//             int[,] matrizA = {
//                 { 1, 2, 3 },
//                 { 4, 5, 6 },
//                 { 7, 8, 9 }
//             };
//             int[,] matrizB = {
//                 { 9, 8, 7 },
//                 { 6, 5, 4 },
//                 { 3, 2, 1 }
//             };
//             int[,] matrizC = new int[3, 3];

//             // Somando as matrizes
//             for (int i = 0; i < matrizA.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matrizA.GetLength(1); j++)
//                 {
//                     matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
//                 }
//             }

//             // Exibindo a matriz resultante
//             Console.WriteLine("Resultado da soma das matrizes:");
//             for (int i = 0; i < matrizC.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matrizC.GetLength(1); j++)
//                 {
//                     Console.Write(matrizC[i, j] + " ");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }



