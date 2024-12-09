// using System;

// namespace Exercicio_1
// {
//     class Exercicio_1
//     {
//         public delegate double Media(int[] valores);

//         static double CalcularMedia(int[] valores)
//         {
//             int soma = 0;
//             foreach (int valor in valores)
//             {
//                 soma += valor;
//             }
//             return (double)soma / valores.Length;
//         }

//         static void Main(string[] args)
//         {
//             int[] vetor = new int[10];
//             for (int i = 0; i < 10; i++)
//             {
//                 System.Console.WriteLine($"Digite o {i+1}° numero: ");
//                 vetor[i] = int.Parse(Console.ReadLine());
//             }
//             Media calcularMedia = CalcularMedia;

//             double resultado = calcularMedia(vetor);
//             Console.WriteLine($"A média dos valores é: {resultado}");
//         }
//     }
// }
