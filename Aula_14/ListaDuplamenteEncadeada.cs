// using System;

// namespace ListaDuplamenteEncadeada
// {
//     public class ListaDuplamenteEncadeada
//     {
//         class Node
//         {
//             public int valor;
//             public Node? proximo;
//             public Node? anterior;
//         }

//         static Node? inicio = null;

//         // Método para inserir um valor na lista
//         static void Inserir(int valor)
//         {
//             Node novoNode = new Node { valor = valor, proximo = null, anterior = null };

//             // Se a lista estiver vazia
//             if (inicio == null)
//             {
//                 inicio = novoNode;
//             }
//             else
//             {
//                 Node atual = inicio;

//                 // Percorrer a lista até o final
//                 while (atual.proximo != null)
//                 {
//                     atual = atual.proximo;
//                 }

//                 // Inserir no final
//                 atual.proximo = novoNode;
//                 novoNode.anterior = atual;
//             }
//         }

//         // Método para excluir um valor da lista
//         static void Excluir(int valor)
//         {
//             // Verifica se a lista está vazia
//             if (inicio == null)
//             {
//                 Console.WriteLine("Lista vazia");
//                 return;
//             }

//             // Verifica se o valor a ser excluído está no início
//             if (inicio.valor == valor)
//             {
//                 inicio = inicio.proximo;
//                 if (inicio != null)
//                 {
//                     inicio.anterior = null;
//                 }
//                 return;
//             }

//             // Percorre a lista para encontrar o nó com o valor
//             Node atual = inicio;
//             while (atual != null && atual.valor != valor)
//             {
//                 atual = atual.proximo;
//             }

//             // Verifica se o nó foi encontrado
//             if (atual != null)
//             {
//                 // Atualiza os ponteiros para excluir o nó
//                 if (atual.anterior != null)
//                 {
//                     atual.anterior.proximo = atual.proximo;
//                 }
//                 if (atual.proximo != null)
//                 {
//                     atual.proximo.anterior = atual.anterior;
//                 }
//             }
//         }

//         // Método para listar os valores da lista
//         static void Listar()
//         {
//             Node? atual = inicio;
//             if (atual == null)
//             {
//                 Console.WriteLine("Lista vazia");
//                 return;
//             }

//             while (atual != null)
//             {
//                 Console.WriteLine(atual.valor);
//                 atual = atual.proximo;
//             }
//         }

//         // Método para testar a lista
//         static void Main(string[] args)
//         {
//             Inserir(10);
//             Inserir(20);
//             Inserir(30);
//             Console.WriteLine("Lista após inserção:");
//             Listar();

//             Excluir(20);
//             Console.WriteLine("Lista após exclusão do valor 20:");
//             Listar();

//             Excluir(10);
//             Console.WriteLine("Lista após exclusão do valor 10:");
//             Listar();

//             Excluir(30);
//             Console.WriteLine("Lista após exclusão do valor 30:");
//             Listar();
//         }
//     }
// }
