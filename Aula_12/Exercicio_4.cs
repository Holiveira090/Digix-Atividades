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
//                 // Imprime o número
//                 Console.Write(vetor[i]);

//                 // Se não for o último número, imprime a vírgula e o espaço
//                 if (i < vetor.Length - 1)
//                 {
//                     Console.Write(", ");
//                 }
//             }
//             Console.WriteLine();  // Quebra a linha após imprimir todos os números
//         }



//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Digite uma lista de numeros SEPARADOS por espaço!");
//             string entrada = Console.ReadLine();
//             string[] partes = entrada.Split(' ');
//             int[] vetor = new int[partes.Length];
//             for (int i = 0; i < partes.Length; i++)
//             {
//                 vetor[i] = int.Parse(partes[i]);
//             }
//             Imprimir(vetor);
//             Ordenar(vetor);
//             System.Console.WriteLine("Com ordenação decrescente");
//             Imprimir(vetor);
//         }
//     }
// }