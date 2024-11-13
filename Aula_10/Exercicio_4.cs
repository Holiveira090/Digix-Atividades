// using System;

// namespace Exercicio_4
// {
//     class Exercicio_4
//     {
//         static int Mdc(int x, int n)
//         {
//             if (n == 0)
//             {
//                 return x;
//             }
//             return Mdc(n, x % n);
//         }



//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Digite um numero inteiro x: ");
//             int x = int.Parse(Console.ReadLine());
//             System.Console.WriteLine("Digite um numero inteiro n: ");
//             int n = int.Parse(Console.ReadLine());

//             System.Console.WriteLine($"O MDC de {x} e {n} é {Mdc(x, n)}");


//         }
//     }
// }