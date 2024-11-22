// using System;

// namespace Exercicio_3
// {
//     class Exercicio_3
//     {
//         static void Ordenar(int[] vetor)
//         {
//             int menor;
//             int aux;
//             for (int i = 0; i < vetor.Length - 1; i++)
//             {
//                 menor = i;
//                 for (int j = i + 1; j < vetor.Length; j++)
//                 {
//                     if (vetor[j] < vetor[menor])
//                     {
//                         menor = j;
//                     }
//                 }

//                 aux = vetor[i];
//                 vetor[i] = vetor[menor];
//                 vetor[menor] = aux;
//             }
//         }

//         static void Imprimir(int[] vetor)
//         {
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 // Imprime o elemento
//                 Console.Write(vetor[i]);

//                 // Se não for o último elemento, imprime a vírgula e o espaço
//                 if (i < vetor.Length - 1)
//                 {
//                     Console.Write(", ");
//                 }
//             }
//             Console.WriteLine(); 
//         }

        
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Digite uma lista de números separados por espaço:");
//             string entrada = Console.ReadLine(); 
//             string[] partes = entrada.Split(' '); 

//             int[] vetor = new int[partes.Length];
//             for (int i = 0; i < partes.Length; i++)
//             {
//                 vetor[i] = int.Parse(partes[i]); 
//             }
//             Console.WriteLine("Desorganizado: ");
//             Imprimir(vetor);
//             Ordenar(vetor);
//             Console.WriteLine("Organizado: ");
//             Imprimir(vetor);
//         }
//     }
// }
