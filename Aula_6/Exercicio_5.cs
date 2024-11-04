// using System;

// namespace Exercico_5
// {
//     class Exercico_5
//     {
//         static void Main(string[] args)
//         {  
//             int[,] matriz = new int[4, 4] 
//             {
//                 { 1, 2, 3, 4}, 
//                 { 5, 6, 7, 8}, 
//                 { 9, 10, 11, 12}, 
//                 { 13, 14, 15, 16}
//             };
//             int[,] matriz2 = new int[4, 4] 
//             {
//                 { 1, 2, 3, 4}, 
//                 { 5, 6, 7, 8}, 
//                 { 9, 10, 11, 12}, 
//                 { 13, 14, 15, 16}
//             };  
//             int[,] matriz3 = new int[4, 4];
            
//             for (int i = 0; i < 4; i++)
//              {
//                  for (int j = 0; j < 4; j++)
//                  {
//                      matriz3[i, j] = matriz[i, j] + matriz2[i, j];
//                  }
//              }
//             Console.WriteLine("Resultado da soma das matrizes:");
//                  for (int i = 0; i < 4; i++)
//                  {
//                      for (int j = 0; j < 4; j++)
//                      {
//                          Console.Write(matriz3[i, j] + " ");
//                      }
//                      Console.WriteLine();
//                  }
        
            
//         }
//     }
// }
