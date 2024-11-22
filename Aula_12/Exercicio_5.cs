// using System;
// using System.Diagnostics;

// namespace BubbleSort
// {
//     class Program
//     {
//         static void Merge(int[] vetor, int inicio, int fim)
//         {
//             if (inicio < fim)
//             {
//                 int meio = (inicio + fim) / 2;
//                 Merge(vetor, inicio, meio);
//                 Merge(vetor, meio + 1, fim);
//                 Intercalar(vetor, inicio, meio, fim);
//             }
//         }

//         static void Intercalar(int[] vetor, int inicio, int meio, int fim)
//         {
//             int[] aux = new int[vetor.Length];
//             for (int j = inicio; j <= fim; j++)
//             {
//                 aux[j] = vetor[j];
//             }
//             int i1 = inicio;
//             int i2 = meio + 1;
//             int i3 = inicio;

//             while (i1 <= meio && i2 <= fim)
//             {
//                 if (aux[i1] < aux[i2])
//                 {
//                     vetor[i3] = aux[i1];
//                     i1++;
//                 }
//                 else
//                 {
//                     vetor[i3] = aux[i2];
//                     i2++;
//                 }
//                 i3++;
//             }

//             while (i1 <= meio)
//             {
//                 vetor[i3] = aux[i1];
//                 i1++;
//                 i3++;
//             }

//             while (i2 <= fim)
//             {
//                 vetor[i3] = aux[i2];
//                 i2++;
//                 i3++;
//             }
//         }

//         static void Bubble(int[] vetor)
//         {
//             int aux;
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 for (int j = 0; j < vetor.Length - 1 - i; j++) // Otimização para reduzir comparações
//                 {
//                     if (vetor[j] > vetor[j + 1])
//                     {
//                         aux = vetor[j];
//                         vetor[j] = vetor[j + 1];
//                         vetor[j + 1] = aux;
//                     }
//                 }
//             }
//         }

//         static void Selection(int[] vetor)
//         {
//             int menor, aux;
//             for (int i = 0; i < vetor.Length; i++)
//             {
//                 menor = i;
//                 for (int j = i + 1; j < vetor.Length; j++)
//                 {
//                     if (vetor[j] < vetor[menor])
//                     {
//                         menor = j;
//                     }
//                 }
//                 aux = vetor[i];
//                 vetor[i] = vetor[menor];
//                 vetor[menor] = aux;
//             }
//         }

//         static void Insertion(int[] vetor)
//         {
//             int aux, j;
//             for (int i = 1; i < vetor.Length; i++)
//             {
//                 aux = vetor[i];
//                 j = i - 1;
//                 while (j >= 0 && vetor[j] > aux)
//                 {
//                     vetor[j + 1] = vetor[j];
//                     j--;
//                 }
//                 vetor[j + 1] = aux;
//             }
//         }

//         static void Main()
//         {
//             int[] numeros = new int[100000];
//             for (int i = 0; i < numeros.Length; i++)
//             {
//                 numeros[i] = (i % 100) + 1;
//             }

//             // Criar cópias para cada algoritmo
//             int[] mergeArray = (int[])numeros.Clone();
//             int[] bubbleArray = (int[])numeros.Clone();
//             int[] selectionArray = (int[])numeros.Clone();
//             int[] insertionArray = (int[])numeros.Clone();

//             // Usando Stopwatch para medir o tempo de execução
//             Stopwatch stopwatch = new Stopwatch();

//             // Mede o tempo de execução do BubbleSort
//             stopwatch.Start();
//             Bubble(bubbleArray);
//             stopwatch.Stop();
//             var tempoBubble = stopwatch.ElapsedTicks;

//             // Mede o tempo de execução do MergeSort
//             stopwatch.Restart();
//             Merge(mergeArray, 0, mergeArray.Length - 1);
//             stopwatch.Stop();
//             var tempoMerge = stopwatch.ElapsedTicks;

//             // Mede o tempo de execução do SelectionSort
//             stopwatch.Restart();
//             Selection(selectionArray);
//             stopwatch.Stop();
//             var tempoSelection = stopwatch.ElapsedTicks;

//             // Mede o tempo de execução do InsertionSort
//             stopwatch.Restart();
//             Insertion(insertionArray);
//             stopwatch.Stop();
//             var tempoInsertion = stopwatch.ElapsedTicks;

//             // Determina o melhor algoritmo
//             string melhorAlgoritimo = "";
//             if (tempoBubble < tempoSelection && tempoBubble < tempoInsertion && tempoBubble < tempoMerge)
//             {
//                 melhorAlgoritimo = "BubbleSort";
//             }
//             else if (tempoSelection < tempoBubble && tempoSelection < tempoInsertion && tempoSelection < tempoMerge)
//             {
//                 melhorAlgoritimo = "SelectionSort";
//             }
//             else if (tempoInsertion < tempoBubble && tempoInsertion < tempoSelection && tempoInsertion < tempoMerge)
//             {
//                 melhorAlgoritimo = "InsertionSort";
//             }
//             else
//             {
//                 melhorAlgoritimo = "MergeSort";
//             }

//             // Exibe os tempos de execução e o melhor algoritmo
//             Console.WriteLine($"Tempo de execução BubbleSort: {tempoBubble} ticks");
//             Console.WriteLine($"Tempo de execução SelectionSort: {tempoSelection} ticks");
//             Console.WriteLine($"Tempo de execução InsertionSort: {tempoInsertion} ticks");
//             Console.WriteLine($"Tempo de execução MergeSort: {tempoMerge} ticks");
//             Console.WriteLine($"O melhor algoritmo foi o: {melhorAlgoritimo}");
//         }
//     }
// }
