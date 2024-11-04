// using System;

// namespace Tridimensional
// {
//     class Tridimensional
//     {
//         static void Main(string[] args)
//         {
//             // Matrizes tridimensionais
//             int[,,] matriz3D = new int[2, 2, 2]
//             {
//                 {
//                     {1, 2},
//                     {3, 4}
//                 },
//                 {
//                     {5, 6},
//                     {7, 8}
//                 }
//             };
//             int[,,] matriz3D2 = new int[2, 2, 2]
//             {
//                 {
//                     {1, 2},
//                     {3, 4}
//                 },
//                 {
//                     {5, 6},
//                     {7, 8}
//                 }
//             };

//             // Exibir elementos da matriz3D
//             for (int i = 0; i < matriz3D.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matriz3D.GetLength(1); j++)
//                 {
//                     for (int k = 0; k < matriz3D.GetLength(2); k++)
//                     {
//                         Console.WriteLine($"[{i}, {j}, {k}] = {matriz3D[i, j, k]}");
//                     }
//                 }
//             }

//             // Acessar elementos específicos
//             Console.WriteLine(matriz3D[1, 1, 1]);
//             Console.WriteLine(matriz3D[0, 0, 0]);

//             // Alterando o valor de um elemento
//             matriz3D[1, 1, 1] = 100;
//             Console.WriteLine(matriz3D[1, 1, 1]);

//             // Declaração da matriz para armazenar a soma
//             int[,,] matrizSoma = new int[2, 2, 2];

//             // Somar os elementos de matriz3D e matriz3D2
//             for (int i = 0; i < matriz3D.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matriz3D.GetLength(1); j++)
//                 {
//                     for (int k = 0; k < matriz3D.GetLength(2); k++)
//                     {
//                         matrizSoma[i, j, k] = matriz3D[i, j, k] + matriz3D2[i, j, k];
//                     }
//                 }
//             }

//             // Exibir a matriz resultante da soma
//             Console.WriteLine("Matriz Soma:");
//             for (int i = 0; i < matrizSoma.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matrizSoma.GetLength(1); j++)
//                 {
//                     for (int k = 0; k < matrizSoma.GetLength(2); k++)
//                     {
//                         Console.WriteLine($"[{i}, {j}, {k}] = {matrizSoma[i, j, k]}");
//                     }
//                 }
//             }
//             // Acessar todos os elementos da matrizTri com Foreach
//             foreach (int item in matriz3D)
//             {
//                 System.Console.WriteLine(item);
//             }
//         }
//     }
// }
