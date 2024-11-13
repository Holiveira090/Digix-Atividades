// using System;

// namespace Exercicio_6
// {
//     class Exercicio_6
//     {
//         static int MediaVetor(int[] vetor, int indice)
//         {
//             if (indice == vetor.Length)
//             {
//                 return 0;
//             }
//             return vetor[indice] + MediaVetor(vetor, indice + 1);
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

//             System.Console.WriteLine($"A média dos numeros é {MediaVetor(vetor, 0)/vetor.Length}");

            


//         }
//     }
// }