// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Exercicio_2
// {
//     public class Exercicio_2
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
//         static void Contem(int valor)
//         {
//             Node? atual = inicio;
//             while (atual != null)
//             {
//                 if (atual.valor == valor)
//                 {
//                     Console.WriteLine($"{valor} True");
//                     return;
//                 }
//                 atual = atual.proximo;
//             }

//             // Se não encontrou o valor
//             Console.WriteLine($"{valor} False");
//         }

//         static void Main()
//         {
//             Enfileirar(10);
//             Enfileirar(20);
//             Enfileirar(30);
//             Enfileirar(40);
//             Listar();
//             Contem(20);
//             Contem(50);
//         }
//     }
// }