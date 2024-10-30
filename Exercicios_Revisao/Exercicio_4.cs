// using System;

// namespace Exercicio_4
// {
//     class Exercicio_4
//     {
//         static void Main(string[] args)
//         {  
//             int numero;
//             int maior = int.MinValue;
//             int menor = int.MaxValue;


//             while (true)
//             {
//                 System.Console.WriteLine("Digite um numero (-1 para o loop)");
//                 numero = int.Parse(Console.ReadLine());

//                 if (numero == -1)
//                 {
//                     break;
//                 }

//                 if (numero > maior)
//                 {
//                     maior = numero;
//                 }

//                 if (numero < menor)
//                 {
//                     menor = numero;
//                 }
//             }

//             Console.WriteLine($"O maior número digitado foi: {maior}");
//             Console.WriteLine($"O menor número digitado foi: {menor}");
//         }
//     }
// }
