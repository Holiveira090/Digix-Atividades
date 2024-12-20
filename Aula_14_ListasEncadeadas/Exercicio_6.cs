// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_14
// {
//     public class Fila
//     {
//         class Node
//         {
//             public int valor;
//             public Node? proximo;
//         }

//         static Node? inicio = null;
//         static Node? fim = null;

//         static int contador = 0;

//         // Enfileirar é acrescentar um elemento no final da fila
//         static void Enfileirar(int valor)
//         {
//             // Cria um novo no com valor fornecido
//             Node novoNode = new Node { valor = valor, proximo = null };

//             // Se a fila estiver vazia, o novo nó é o início da fila
//             if (inicio == null)
//             {
//                 inicio = novoNode;
//             }
//             else
//             {
//                 // Se a fila não estiver vazia, o novo nó é o próximo do último nó
//                 fim!.proximo = novoNode; // fim!.proximo é seguro pois sabemos que fim não é nulo
//             }

//             // Atualiza o fim da fila
//             fim = novoNode;

//             // Incrementa o contador
//             contador++;
//         }

//         static void Tamanho()
//         {
//             int contador = 0;
//             if (inicio == null)
//             {
//                 Console.WriteLine("Fila vazia!");
//                 return;
//             }
//             Node? atual = inicio;
//             while (atual != null)
//             {
//                 atual = atual.proximo;
//                 contador++;
//             }
//             System.Console.WriteLine(contador);
//         }


//         // Listar a Fila
//         static void Listar()
//         {
//             if (inicio == null)
//             {
//                 Console.WriteLine("Fila vazia!");
//                 return;
//             }
//             System.Console.WriteLine("Listando a Fila");
//             Node? atual = inicio;
//             while (atual != null)
//             {
//                 Console.WriteLine(atual.valor);
//                 atual = atual.proximo;
//             }
//         }

//         static void Main()
//         {
//             Enfileirar(10);
//             Enfileirar(20);
//             Enfileirar(30);
//             Enfileirar(40);
//             Enfileirar(50);
//             Listar();
//             System.Console.WriteLine($"O tamnho da fila é: ");
//             Tamanho();
//         }
//     }
// }