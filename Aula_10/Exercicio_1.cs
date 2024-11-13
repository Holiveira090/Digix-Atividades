// using System;

// namespace Exercicio_1
// {
//     class Exercicio_1
//     {
//         static int Soma(int n)
//         {
//             if (n == 1)
//             {
//                 return 1;
//             }
//             return n + Soma(n - 1);
//         }



//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Digite a quantidades de numero que deseja somar: ");
//             int n = int.Parse(Console.ReadLine());
//             System.Console.WriteLine($"A soma dos numeros de 1 a {n} é: {Soma(n)}");
//         }
//     }
// }