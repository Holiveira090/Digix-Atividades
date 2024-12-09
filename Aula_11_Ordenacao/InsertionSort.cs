// using System;

// namespace InsertionSort
// {
//     class InsertionSort
//     {
//         // Fução de ordenação usando InsertionSort
//         static void Ordenar(int[] vetor)
//         {
//             int aux, j;
//             for (int i = 1; i < vetor.Length; i++)
//             {
//                 aux = vetor[i];
//                 j = i - 1;
//                 while (j >= 0 && vetor[j] > aux)
//                 {
//                     vetor[j + 1] = vetor[j];
//                     j--;
//                 }
//                 vetor[j + 1] = aux;
//             }

//         }


//         static void Imprimir(int[] vetor)
//         {
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 System.Console.WriteLine(vetor[i] + " ");
//             }
//             System.Console.WriteLine();
//         }



//         static void Main(string[] args)
//         {
//             int[] vetor = { 8, 4, 6, 7, 9, 0, 3, 5 };
//             System.Console.WriteLine("sem ordenação");
//             Imprimir(vetor);
//             Ordenar(vetor);
//             System.Console.WriteLine("Com ordenação");
//             Imprimir(vetor);
//         }
//     }
// }


// Decrescente


// using System;

// namespace InsertionSort
// {
//     class InsertionSort
//     {
//         // Fução de ordenação usando InsertionSort
//         static void Ordenar(int[] vetor)
//         {
//             int aux, j;
//             for (int i = 1; i < vetor.Length; i++)
//             {
//                 aux = vetor[i];
//                 j = i - 1;
//                 while (j >= 0 && vetor[j] < aux)
//                 {
//                     vetor[j + 1] = vetor[j];
//                     j--;
//                 }
//                 vetor[j + 1] = aux;
//             }

//         }


//         static void Imprimir(int[] vetor)
//         {
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 System.Console.WriteLine(vetor[i] + " ");
//             }
//             System.Console.WriteLine();
//         }



//         static void Main(string[] args)
//         {
//             int[] vetor = { 8, 4, 6, 7, 9, 0, 3, 5 };
//             System.Console.WriteLine("sem ordenação");
//             Imprimir(vetor);
//             Ordenar(vetor);
//             System.Console.WriteLine("Com ordenação");
//             Imprimir(vetor);
//         }
//     }
// }