using System;

namespace ListaDuplamenteEncadeada
{
    public class ListaDuplamenteEncadeada
    {
        class Node
        {
            public int valor;
            public Node? proximo;
            public Node? anterior;
        }

        static Node? inicio = null;

        // Método para inserir um valor na lista
        static void Inserir(int valor)
        {
            Node novoNode = new Node { valor = valor, proximo = null, anterior = null };

            // Se a lista estiver vazia
            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                Node atual = inicio;

                // Percorrer a lista até o final
                while (atual.proximo != null)
                {
                    atual = atual.proximo;
                }

                // Inserir no final
                atual.proximo = novoNode;
                novoNode.anterior = atual;
            }
        }

        // Método para excluir um valor da lista
        static void Excluir(int valor)
        {
            // Verifica se a lista está vazia
            if (inicio == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            // Verifica se o valor a ser excluído está no início
            if (inicio.valor == valor)
            {
                inicio = inicio.proximo;
                if (inicio != null)
                {
                    inicio.anterior = null;
                }
                return;
            }

            // Percorre a lista para encontrar o nó com o valor
            Node atual = inicio;
            while (atual != null && atual.valor != valor)
            {
                atual = atual.proximo;
            }

            // Verifica se o nó foi encontrado
            if (atual != null)
            {
                // Atualiza os ponteiros para excluir o nó
                if (atual.anterior != null)
                {
                    atual.anterior.proximo = atual.proximo;
                }
                if (atual.proximo != null)
                {
                    atual.proximo.anterior = atual.anterior;
                }
            }
        }

        // Método para listar os valores da lista
        static void Listar()
        {
            Node? atual = inicio;
            if (atual == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            while (atual != null)
            {
                Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }
        static void RemoverRecorrenciaTodos(int valor)
        {
            Node? atual = inicio;
            while (atual != null)
            {
                // Caso o nó seja o inicio da lista
                if (atual.anterior == null)
                {
                    inicio = atual.proximo;
                    if (inicio != null)
                    {
                        inicio.anterior = null;
                    }
                }
                // Caso o nó seja do fim da lista
                else if (atual.proximo == null)
                {
                    atual.anterior.proximo = null;
                }
                else
                {
                    // atualiza os ponteiros do nó anterior e do nó posterior
                    atual.anterior.proximo = atual.proximo;
                    atual.proximo.anterior = atual.anterior;
                }
            }
            // avança para o proximo nó
            atual = atual.proximo;
        }

        // Método para testar a lista
        static void Main(string[] args)
        {
            Inserir(10);
            Inserir(20);
            Inserir(30);
            Inserir(30);
            Inserir(30);
            Console.WriteLine("Lista após inserção:");
            Listar();
            RemoverRecorrenciaTodos(30);
            Listar();
        }
    }
}
