// using System;

// namespace Lista
// {
//     public class Lista
//     {
//         static int[] vetor = new int[10];

//         static void Inserir(int valor)
//         {
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 if (vetor[i] == 0)
//                 {
//                     vetor[i] = valor;
//                     break;
//                 }
//             }
//         }
//         static void Remover(int valor)
//         {
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 if (vetor[i] == valor)
//                 {
//                     vetor[i] = 0;
//                     break;
//                 }
//             }
//         }
//         static void Listar()
//         {
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 if (vetor[i] != 0)
//                 {
//                     System.Console.WriteLine(vetor[i]);
//                 }
//             }
//         }
//         // Listar de forma inversa
//         static void ListarInverso()
//         {
//             for (int i = vetor.Length; i <= 0; i++)
//             {
//                 if (vetor[i] != 0)
//                 {
//                     System.Console.WriteLine(vetor[i]);
//                 }
//             }
//         }

//         public static void Main(string[] args)
//         {
//             Inserir(10);
//             Inserir(20);
//             Inserir(30);
//             Inserir(40);
//             Inserir(50);
//             Inserir(60);
//             Inserir(70);
//             Inserir(80);
//             Inserir(90);
//             Inserir(100);
//             Listar();
//             System.Console.WriteLine("listar de forma inversa:");
//             ListarInverso();
//             Remover(50);
//             System.Console.WriteLine("Listar após remover o valor 50");
//             Listar();
//         }
//     }
// }
