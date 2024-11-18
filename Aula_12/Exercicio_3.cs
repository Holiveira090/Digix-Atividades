// using System;

// namespace Exercicio_3
// {
//     class Exercicio_3
//     {
//         static void Ordenar(string[] vetor)
//             {
//                int menor; 
//                string aux;
//                for (int i = 0; i < vetor.Length; i++)
//                {
//                     menor = i;
//                     for (int j = i + 1; j < vetor.Length; j++)
//                     {
//                         if (string.Compare(vetor[j], vetor[menor]) < 0)
//                         {
//                             menor = j;
//                         }
//                     }
//                     aux = vetor[i];
//                     vetor[i] = vetor[menor];
//                     vetor[menor] = aux;
//                }
//             }
//         static void Imprimir(string[] vetor)
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
//             Console.WriteLine(); 
//         }



//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Digite uma lista de numeros SEPARADOS por espaço!");
//             string entrada = Console.ReadLine();
//             string[] partes = entrada.Split(' ');
//             string[] vetor = new string[partes.Length];
//             for (int i = 0; i < partes.Length; i++)
//             {
//                 vetor[i] = partes[i];
//             }
//             System.Console.WriteLine("Desorganizado: ");
//             Imprimir(vetor);
//             System.Console.WriteLine("Organizado: ");
//             Ordenar(vetor);
//             Imprimir(vetor);
//         }
//     }
// }
