// using System;

// namespace Funcao
// {
//     class Funcao
//     {
//         // Função
//         static int soma(int a, int b)
//         {
//             return a + b;
//         }

//         // Procedimento
//         static void imprimir(string texto)
//         {
//             System.Console.WriteLine(texto);
//         }

//         // Função com 3 parametros
//         static double multiplicacao(double a, double b, double c)
//         {
//             return a * b * c;
//         }
//         static double multiplicacao2(double a = 10, double b = 20, double c = 30)
//         {
//             return a * b * c;
//         }

//         // Função com parametros de vetor
//         static int somaVetor(int[] vetor)
//         {
//             int soma = 0;
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 soma += vetor[i];
//             }
//             return soma;
//         }

//         // Função com parametros de matriz
//         static int somaMatriz(int[,] matriz)
//         {
//             int soma = 0;
//             for (int i = 0; i < matriz.GetLength(0); i++)
//             {
//                 for (int j = 0; j < matriz.GetLength(1); j++)
//                 {
//                     soma += matriz[i, j];
//                 }
//             }
//             return soma;
//         }





//         static void Main(string[] args)
//         {
//             int a = 10;
//             int b = 20;
//             int resultado = soma(a, b);
//             System.Console.WriteLine($"A soma de {a} e {b} é {resultado}");

//             // Chamar o procedimento imprimir
//             imprimir("Olá mundo!");

//             // Chamar a função multiplicação
//             double x = 10;
//             double y = 20;
//             double z = 30;

//             double resultado2 = multiplicacao(x, y, z);
//             System.Console.WriteLine($"O resultado da multiplicação é {resultado2}");

//             // Chamar a função multiplicação2
//             double resultado3 = multiplicacao2();
//             System.Console.WriteLine($"O resultado da multiplicação2 é {resultado3}");

//             // Chamar função somaVetor
//             int[] vetor = {1, 2, 3, 4, 5 };
//             int resultado4 = somaVetor(vetor);
//             System.Console.WriteLine($"O resultado da soma do vetor é: {resultado4}");

//             // Chamar função somaMatriz
//             int[,] matriz = {
//                 { 1, 2, 3 },
//                 { 4, 5, 6 },
//                 { 7, 8, 9 }
//             };
//             int resultado5 = somaMatriz(matriz);
//             System.Console.WriteLine($"O resultado da soma da matriz é {resultado5}");

//         }
//     }
// }
