// using System;

// namespace BubleSort
// {
//     class BubleSort
//     {
//             // Função para ordenar em ordem crescente em bubble sort
//             static void Ordenar(int[] vetor)
//             {
//                 int aux;
//                 for (int i = 0; i < vetor.Length; i++)
//                 {
//                     for (int j = 0; j < vetor.Length - 1; j++)
//                     {
//                         if(vetor[j]>vetor[j+1])
//                         {
//                             aux = vetor[j];
//                             vetor[j] = vetor[j+1];
//                             vetor[j+1] = aux;
//                         }
                        
//                     }
//                 }
//             }
//             static void Imprimir(int[] vetor)
//             {
//                 for (int i = 0; i < vetor.Length; i++)
//                 {
//                     System.Console.WriteLine(vetor[i] + " ");
//                 }
//                 System.Console.WriteLine();
//             }


            
//         static void Main(string[] args)
//         {
//             int[] vetor = {2, 1, 5, 7, 3, 4};
//             System.Console.WriteLine("vetor desordenado");
//             Imprimir(vetor);
//             Ordenar(vetor);
//             System.Console.WriteLine("vetor ordenado");
//             Imprimir(vetor);
//         }
//     }
// }