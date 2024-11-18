// using System;

// namespace Exercicio_2
// {
//     class Exercicio_2
//     {
//         static void Ordenar(int[] vetor)
//         {
//             int aux;
//             int contador = 0;
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 for (int j = 0; j < vetor.Length - 1; j++)
//                 {
//                     if (vetor[j] > vetor[j + 1])
//                     {
//                         aux = vetor[j];
//                         vetor[j] = vetor[j + 1];
//                         vetor[j + 1] = aux;
//                         contador++;
//                     }

//                 }
//             }
//             System.Console.WriteLine($"Iterações: {contador}");
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
//             System.Console.WriteLine("Desorganizado: ");
//             Imprimir(vetor);
//             System.Console.WriteLine("Organizado: ");
//             Ordenar(vetor);
//             Imprimir(vetor);
//         }
//     }
// }
