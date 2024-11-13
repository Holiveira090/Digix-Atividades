// using System;

// namespace SelectionSort
// {
//     class SelectionSort
//     {
//             // Fução de ordenação usando SelectionSort
//             static void Ordenar(int[] vetor)
//             {
//                int menor, aux;
//                for (int i = 0; i < vetor.Length; i++)
//                {
//                     menor = i;
//                     for (int j = i + 1; j < vetor.Length; j++)
//                     {
//                         if (vetor[j] < vetor[menor])
//                         {
//                             menor = j;
//                         }
//                     }
//                     aux = vetor[i];
//                     vetor[i] = vetor[menor];
//                     vetor[menor] = aux;
//                }
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
//             int[] vetor = {8, 4, 6, 7, 9, 0, 3, 5};
//             System.Console.WriteLine("sem ordenação");
//             Imprimir(vetor);
//             Ordenar(vetor);
//             System.Console.WriteLine("Com ordenação");
//             Imprimir(vetor);
//         }
//     }
// }