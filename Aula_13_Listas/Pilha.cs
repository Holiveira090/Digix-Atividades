// using System;

// namespace Pilha
// {
//     public class Pilha
//     {
//         static int[] pilha = new int[10];
//         static int topo = 0; // Topo da pilha

//         // Adiciona um elemento na pilha
//         public static void Adicionar(int valor)
//         {
//             if (topo < pilha.Length)
//             {
//                 pilha[topo] = valor;
//                 topo++; // Move o topo para o próximo índice
//             }
//             else
//             {
//                 System.Console.WriteLine("Pilha cheia");
//             }
//         }

//         // Remove o último elemento da pilha
//         public static void Remover()
//         {
//             if (topo > 0)
//             {
//                 topo--; // Move o topo para o elemento anterior, efetivamente "removendo" o último item
//             }
//             else
//             {
//                 System.Console.WriteLine("Pilha vazia");
//             }
//         }

//         // Lista os elementos da pilha
//         public static void Listar()
//         {
//             for (int i = topo - 1; i >= 0; i--) // Exibe do topo até o início
//             {
//                 System.Console.WriteLine(pilha[i]);
//             }
//         }

//         // Função principal que testa a pilha
//         public static void Main(string[] args)
//         {
//             Adicionar(10);
//             Adicionar(30);
//             Adicionar(40);
//             Adicionar(70);
//             Adicionar(20);
//             Adicionar(50);
//             Adicionar(80);
//             Adicionar(60);
//             Adicionar(90);
//             Adicionar(100);

//             System.Console.WriteLine("Listando: ");
//             Listar(); // Exibe os elementos atuais da pilha

//             Remover(); // Remove o último item

//             System.Console.WriteLine("Listando depois de remover: ");
//             Listar(); // Exibe a pilha após a remoção
//         }
//     }
// }
