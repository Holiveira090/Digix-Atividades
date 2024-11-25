// using System;

// namespace PilhaEncadeada
// {
//     class PilhaEncadeada
//     {
//         // Estrutura de um nó (Node) para armazenar valores e apontar para o próximo nó
//         class Node
//         {
//             public int Valor;      // Valor armazenado no nó
//             public Node? Proximo;  // Referência para o próximo nó na lista encadeada
//         }
//         static Node? topo = null;

//         // Empilhar
//         static void Empilhar(int valor)
//         {
//             Node novoNode = new Node { Valor = valor, Proximo = topo};
//             //atualiza o topo do nó
//             topo = novoNode;
//         }
//         static void Desempilhar()
//         {
//             if (topo == null)
//             {
//                 System.Console.WriteLine("Pilha vazia!");
//                 return;
//             }
//             System.Console.WriteLine($"Desempilhando: {topo.Valor}");
//             topo = topo.Proximo;
//         }
//         static void Listar()
//         {
//             if (topo == null)
//             {
//                 System.Console.WriteLine("Pilha vazia!");
//                 return;
//             }
//             System.Console.WriteLine("Listando a Pilha encadeada:");
//             Node? atual = topo;
//             while (atual != null)
//             {
//                 System.Console.WriteLine(atual.Valor);
//                 atual = atual.Proximo;
//             }

//         }
//         public static void Main(string[] args)
//         {
//             Empilhar(10);
//             Empilhar(20);
//             Empilhar(30);
//             Empilhar(40);
//             Listar();
//             Desempilhar();
//             Listar();

//         }

//     }
// }