// using System;

// namespace Exercicio_3
// {
//     class Exercicio_3
//     {
//         static void Main(string[] args)
//         {
//             int[] vetor = new int[4];

//             for (int i = 0; i < 4; i++)
//             {
//                 Console.WriteLine($"Digite o {i + 1}° número: ");
//                 vetor[i] = int.Parse(Console.ReadLine());
//             }

//             Console.WriteLine("\nVerificação de números palíndromos:");
//             for (int i = 0; i < 4; i++)
//             {
//                 int numero = vetor[i];
//                 int original = numero;
//                 int reverso = 0;

//                 // Calcula o reverso do número
//                 while (numero > 0)
//                 {
//                     int digito = numero % 10;
//                     reverso = reverso * 10 + digito;
//                     numero /= 10;
//                 }

//                 // Verifica se o número é palíndromo
//                 if (original == reverso)
//                 {
//                     Console.WriteLine($"{original} é um palíndromo.");
//                 }
//                 else
//                 {
//                     Console.WriteLine($"{original} não é um palíndromo.");
//                 }
//             }
//         }
//     }
// }
