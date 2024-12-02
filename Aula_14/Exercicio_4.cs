// // using System;

// // namespace PilhaEncadeada
// // {
// //     class PilhaEncadeada
// //     {
// //         // Estrutura de um nó (Node) para armazenar valores e apontar para o próximo nó
// //         class Node
// //         {
// //             public int Valor;      // Valor armazenado no nó
// //             public Node? Proximo;  // Referência para o próximo nó na lista encadeada
// //         }
// //         static Node? topo = null;

// //         // Empilhar
// //         static void Empilhar(int valor)
// //         {
// //             Node novoNode = new Node { Valor = valor, Proximo = topo };
// //             //atualiza o topo do nó
// //             topo = novoNode;
// //         }
// //         static void Desempilhar()
// //         {
// //             if (topo == null)
// //             {
// //                 System.Console.WriteLine("Pilha vazia!");
// //                 return;
// //             }
// //             System.Console.WriteLine($"Desempilhando: {topo.Valor}");
// //             topo = topo.Proximo;
// //         }
// //         static void Listar()
// //         {
// //             if (topo == null)
// //             {
// //                 System.Console.WriteLine("Pilha vazia!");
// //                 return;
// //             }
// //             Node? atual = topo;
// //             while (atual != null)
// //             {
// //                 System.Console.WriteLine(atual.Valor);
// //                 atual = atual.Proximo;
// //             }

// //         }
// //         static void Inverter()
// //         {
// //             if (topo == null)
// //             {
// //                 System.Console.WriteLine("Pilha vazia!");
// //                 return;
// //             }

// //             System.Console.WriteLine("Listando a Pilha encadeada invertida:");

// //             Node? anterior = null;
// //             Node? atual = topo;
// //             Node? proximo = null;

// //             // Invertendo a pilha (invertendo os ponteiros)
// //             while (atual != null)
// //             {
// //                 proximo = atual.Proximo; // Salva o próximo nó
// //                 atual.Proximo = anterior; // Inverte o ponteiro para o nó anterior
// //                 anterior = atual;         // Avança o anterior para o nó atual
// //                 atual = proximo;          // Avança para o próximo nó
// //             }

// //             topo = anterior; // O topo agora é o último nó invertido

// //             // Listando a pilha após a inversão
// //             Listar();
// //         }


// //         public static void Main(string[] args)
// //         {
// //             Empilhar(10);
// //             Empilhar(20);
// //             Empilhar(30);
// //             Empilhar(40);
// //             Listar();
// //             Inverter();

// //         }

// //     }
// // }

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
//         static void Reverter()
//         {
//             if (topo == null || topo.Proximo == null)
//             {
//                 return;
//             }
//             Node? anterior = null;
//             Node? atual = topo;
//             Node? proximo;

//             while (atual != null)
//             {
//                 proximo = atual.Proximo;
//                 atual.Proximo = anterior;
//                 anterior = atual;
//                 atual = proximo;
//             }
//             // Ajusta o topo da pilha
//             topo = anterior;
//         }
//         public static void Main(string[] args)
//         {
//             Empilhar(10);
//             Empilhar(20);
//             Empilhar(30);
//             Empilhar(40);
//             Listar();
//             Reverter();
//             Listar();


//         }

//     }
// }