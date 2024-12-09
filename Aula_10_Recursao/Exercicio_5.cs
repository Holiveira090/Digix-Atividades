// using System;

// namespace Exercicio_5
// {
//     class Exercicio_5
//     {
//         static int SomaVetor(int[] vetor, int indice)
//         {
//             if (indice == vetor.Length)
//             {
//                 return 0;
//             }
//             return vetor[indice] + SomaVetor(vetor, indice + 1);
//         }



//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Quantos numeros deseja somar?");
//             int num = int.Parse(Console.ReadLine());
            
//             int[] vetor = new int[num];

//             for (int i = 0; i < num; i++)
//             {
//                 Console.WriteLine("Digite o número que deseja somar: ");
//                 vetor[i] = int.Parse(Console.ReadLine());
//             }

//             System.Console.WriteLine($"A soma dos numeros é {SomaVetor(vetor, 0)}");
//         }
//     }
// }