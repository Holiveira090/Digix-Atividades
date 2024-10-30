// using System;

// namespace Exercicio_1
// {
//     class Exercicio_1
//     {
//         static void Main(string[] args)
//         {   
//             int [] numeros = new int[10];

//             System.Console.WriteLine("Digite 10 numeros inteiros e positivos: ");
//             for (int i = 0; i < 10; i++)
//             {
//                 System.Console.WriteLine($"{i + 1}: ");
//                 numeros[i] = int.Parse(Console.ReadLine());
//             }

//             int maior = numeros[0];
//             int menor = numeros[0];

//             for (int i = 1; i < 10; i++)
//             {
//                 if (numeros[i] > maior)
//                 {
//                     maior = numeros[i];
//                 }
//                 if (numeros[i] < menor)
//                 {
//                     menor = numeros[i];
//                 }   
//             }
//             System.Console.WriteLine($"O maior numero digitado é: {maior}");
//             System.Console.WriteLine($"O menor numero digitado é: {menor}");
//         }
//     }
// }
