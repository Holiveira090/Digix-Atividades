using System;

namespace BubleSort
{
    class Program
    {
        // Função para ordenar em ordem crescente em bubble sort
        static void Bubble(int[] vetor)
        {
            int aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                for (int j = 0; j < vetor.Length - 1 - i; j++) // Otimização para reduzir comparações
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
        }

        static void Selection(int[] vetor)
        {
            int menor, aux;
            for (int i = 0; i < vetor.Length; i++)
            {
                menor = i;
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if (vetor[j] < vetor[menor])
                    {
                        menor = j;
                    }
                }
                aux = vetor[i];
                vetor[i] = vetor[menor];
                vetor[menor] = aux;
            }
        }

        static void Insertion(int[] vetor)
        {
            int aux, j;
            for (int i = 1; i < vetor.Length; i++)
            {
                aux = vetor[i];
                j = i - 1;
                while (j >= 0 && vetor[j] > aux)
                {
                    vetor[j + 1] = vetor[j];
                    j--;
                }
                vetor[j + 1] = aux;
            }
        }

        static void Main()
        {
            int[] numeros = new int[1000];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = (i % 100) + 1;
            }

            // Criar cópias para cada algoritmo
            int[] bubleArray = (int[])numeros.Clone();
            int[] selectionArray = (int[])numeros.Clone();
            int[] insertionArray = (int[])numeros.Clone();

            // Mede o tempo de execução do BubbleSort
            var inicio = DateTime.Now.Ticks; // pega o tempo atual em ticks
            Bubble(bubleArray);
            var tempoBubble = DateTime.Now.Ticks - inicio;

            // Mede o tempo de execução do SelectionSort
            inicio = DateTime.Now.Ticks; // pega o tempo atual em ticks
            Selection(selectionArray);
            var tempoSelection = DateTime.Now.Ticks - inicio;

            // Mede o tempo de execução do InsertionSort
            inicio = DateTime.Now.Ticks; // pega o tempo atual em ticks
            Insertion(insertionArray);
            var tempoInsertion = DateTime.Now.Ticks - inicio;

            string melhorAlgoritimo = "";
            if (tempoBubble < tempoSelection && tempoBubble < tempoInsertion)
            {
                melhorAlgoritimo = "BubbleSort";
            }
            else if (tempoSelection < tempoBubble && tempoSelection < tempoInsertion)
            {
                melhorAlgoritimo = "SelectionSort";
            }
            else
            {
                melhorAlgoritimo = "InsertionSort";
            }

            Console.WriteLine($"Tempo de execução BubbleSort: {tempoBubble} ticks");
            Console.WriteLine($"Tempo de execução SelectionSort: {tempoSelection} ticks");
            Console.WriteLine($"Tempo de execução InsertionSort: {tempoInsertion} ticks");
            Console.WriteLine($"O melhor algoritmo foi o: {melhorAlgoritimo}");
        }
    }
}
