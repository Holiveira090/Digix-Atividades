// using System;

// namespace Exercicio_1
// {
//     class Lista
//     {
//         // Estrutura de um nó (Node) para armazenar valores e apontar para o próximo nó
//         class Node
//         {
//             public int Valor;      // Valor armazenado no nó
//             public Node? Proximo;  // Referência para o próximo nó na lista encadeada
//         }

//         // Variável para armazenar o início da lista encadeada
//         private Node? inicio = null;

//         // Função para inserir um valor no final da lista
//         public void Inserir(int valor)
//         {
//             Node novoNode = new Node { Valor = valor, Proximo = null };

//             if (inicio == null)
//             {
//                 inicio = novoNode;
//             }
//             else
//             {
//                 Node atual = inicio;
//                 while (atual.Proximo != null)
//                 {
//                     atual = atual.Proximo;
//                 }
//                 atual.Proximo = novoNode;
//             }
//         }

//         // Função para inserir um valor em uma posição específica
//         public void InserirNaPosicao(int valor, int posicao)
//         {
//             // Se a posição for inválida
//             if (posicao < 0)
//             {
//                 Console.WriteLine("Posição inválida.");
//                 return;
//             }

//             Node novoNode = new Node { Valor = valor, Proximo = null };

//             // Inserção na posição 0 (início da lista)
//             if (posicao == 0)
//             {
//                 novoNode.Proximo = inicio;
//                 inicio = novoNode;
//                 return;
//             }

//             Node atual = inicio;
//             int contador = 0;

//             // Percorrer até a posição anterior à desejada
//             while (atual != null && contador < posicao - 1)
//             {
//                 atual = atual.Proximo;
//                 contador++;
//             }

//             // Se a posição for maior do que o tamanho da lista, exibe erro
//             if (atual == null)
//             {
//                 Console.WriteLine("Posição inválida.");
//                 return;
//             }

//             // Inserir o novo nó
//             novoNode.Proximo = atual.Proximo;
//             atual.Proximo = novoNode;
//         }

//         // Função para excluir um valor específico da lista
//         public void Excluir(int valor)
//         {
//             if (inicio == null) return;

//             if (inicio.Valor == valor)
//             {
//                 inicio = inicio.Proximo;
//                 return;
//             }

//             Node atual = inicio;
//             while (atual.Proximo != null && atual.Proximo.Valor != valor)
//             {
//                 atual = atual.Proximo;
//             }

//             if (atual.Proximo != null)
//             {
//                 atual.Proximo = atual.Proximo.Proximo;
//             }
//         }

//         // Função para listar todos os valores da lista
//         public void Listar()
//         {
//             if (inicio == null)
//             {
//                 Console.WriteLine("A lista está vazia.");
//                 return;
//             }

//             Node? atual = inicio;
//             Console.WriteLine("Elementos na lista:");

//             while (atual != null)
//             {
//                 Console.WriteLine(atual.Valor);
//                 atual = atual.Proximo;
//             }
//         }

//         // Função principal para execução do programa
//         static void Main()
//         {
//             Lista lista = new Lista();

//             // Insere valores na lista
//             lista.Inserir(10);
//             lista.Inserir(20);
//             lista.Inserir(30);

//             // Lista os valores da lista
//             Console.WriteLine("Lista antes da inserção:");
//             lista.Listar();

//             // Inserir 25 na posição 2
//             Console.WriteLine("Inserir 25 na posição 2:");
//             lista.InserirNaPosicao(25, 2);
//             lista.Listar();

//             // Exclui o valor 20 e lista novamente para verificar a remoção
//             Console.WriteLine("Excluir 20:");
//             lista.Excluir(20);
//             lista.Listar();
//         }
//     }
// }
