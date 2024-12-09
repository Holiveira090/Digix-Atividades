// using System;

// namespace Recursiva
// {
//     class Recursiva
//     {
//         // Método recursivo para somar os pares de um vetor
//         static int Pares(int[] vetor, int n)
//         {
//             // Caso base: quando o índice chega a 0, não há mais elementos para verificar
//             if (n == 0)
//             {
//                 return 0;
//             }
//             else
//             {
//                 // Se o elemento é par, soma com o próximo caso recursivo
//                 if (vetor[n - 1] % 2 == 0)
//                 {
//                     return vetor[n - 1] + Pares(vetor, n - 1);
//                 }
//                 else
//                 {
//                     // Se o elemento não for par, simplesmente chama a recursão sem somar
//                     return Pares(vetor, n - 1);
//                 }
//             }
//         }

//         // Método recursivo para calcular o fatorial
//         static int Fatorial(int n)
//         {
//             if (n == 0)
//             {
//                 return 1;
//             }
//             else
//             {
//                 return n * Fatorial(n - 1);
//             }
//         }

//         // Método recursivo para calcular o Fibonacci
//         static int Fibonacci(int n)
//         {
//             if (n == 0)
//             {
//                 return 0;
//             }
//             else if (n == 1)
//             {
//                 return 1; 
//             }
//             else
//             {
//                 return Fibonacci(n - 1) + Fibonacci(n - 2); 
//             }
//         }

//         static void Main(string[] args)
//         {
//             // Fatorial
//             Console.WriteLine("Digite um numero para calcular o fatorial: ");
//             int numero = int.Parse(Console.ReadLine());
//             Console.WriteLine($"O fatorial de {numero} é: {Fatorial(numero)}");

//             // Fibonacci
//             Console.WriteLine("Digite um numero para calcular o Fibonacci: ");
//             int num = int.Parse(Console.ReadLine());
//             Console.WriteLine($"O Fibonacci de {num} é: {Fibonacci(num)}");

//             // Chamar a função Pares
//             int[] vetor = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//             Console.WriteLine($"A soma dos pares é: {Pares(vetor, vetor.Length)}");
//         }
//     }
// }
