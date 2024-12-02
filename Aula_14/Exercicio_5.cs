// using System;

// namespace Aula_14
// {
//     public class Fila
//     {
//         class Node
//         {
//             public int valor;
//             public Node? proximo;
//         }

//         // Tornar os membros não estáticos para serem específicos de instância
//         private Node? inicio = null;
//         private Node? fim = null;
//         private int contador = 0;

//         // Enfileirar é acrescentar um elemento no final da fila
//         public void Enfileirar(int valor)
//         {
//             // Cria um novo nó com o valor fornecido
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
//         public void Listar()
//         {
//             if (inicio == null)
//             {
//                 Console.WriteLine("Fila vazia!");
//                 return;
//             }
//             Console.WriteLine("Listando a Fila:");
//             Node? atual = inicio;
//             while (atual != null)
//             {
//                 Console.WriteLine(atual.valor);
//                 atual = atual.proximo;
//             }
//         }

//         // Inserir os elementos de outra fila no final da fila atual
//         public void InserirFila(Fila outraFila)
//         {
//             // Se a fila fornecida estiver vazia, não há nada para inserir
//             if (outraFila.inicio == null)
//             {
//                 Console.WriteLine("A segunda fila está vazia!");
//                 return;
//             }

//             // Se a fila atual estiver vazia, a fila atual recebe a segunda fila inteira
//             if (inicio == null)
//             {
//                 inicio = outraFila.inicio;
//                 fim = outraFila.fim;
//             }
//             else
//             {
//                 // Se a fila atual não estiver vazia, percorremos a segunda fila
//                 Node? atual = outraFila.inicio;
//                 while (atual != null)
//                 {
//                     Enfileirar(atual.valor); // Adiciona cada valor da segunda fila na fila atual
//                     atual = atual.proximo;
//                 }
//             }
//         }

//         // Método main para testar
//         static void Main()
//         {
//             // Criando e inserindo elementos na Fila 1
//             Fila fila1 = new Fila();
//             fila1.Enfileirar(10);
//             fila1.Enfileirar(20);

//             // Criando e inserindo elementos na Fila 2
//             Fila fila2 = new Fila();
//             fila2.Enfileirar(30);
//             fila2.Enfileirar(40);

//             // Listando as filas antes da inserção
//             Console.WriteLine("Fila 1 antes da inserção:");
//             fila1.Listar();
//             Console.WriteLine("Fila 2 antes da inserção:");
//             fila2.Listar();

//             // Inserir os elementos da Fila 2 na Fila 1
//             fila1.InserirFila(fila2);

//             // Listando a Fila 1 após a inserção dos elementos da Fila 2
//             Console.WriteLine("\nFila 1 após a inserção da Fila 2:");
//             fila1.Listar();
//         }
//     }
// }
