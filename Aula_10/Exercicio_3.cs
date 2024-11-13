// using System;

// namespace Exercicio_3
// {
//     class Exercicio_3
//     {
//         static int Potencia(int x, int n)
//         {
//             if (n == 0)
//             {
//                 return 1;
//             }
//             return x * Potencia(x, n - 1);
//         }



//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Digite um numero inteiro x: ");
//             int x = int.Parse(Console.ReadLine());
//             System.Console.WriteLine("Digite um numero inteiro não negativo n: ");
//             int n = int.Parse(Console.ReadLine());

//             System.Console.WriteLine($"A potencia de {x} elevado a {n} é {Potencia(x, n)}");


//         }
//     }
// }