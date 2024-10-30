// using System;

// namespace Aula_5
// {
//     class Aula_5
//     {
//         static void Main(string[] args)
//         {  
//             // Formas de declarar o vetor
//             int[] vetor1 = new int[5];
//             int[] vetor2 = new int[] { 1, 2, 3, 4, 5 };
//             int[] vetor3 = { 1, 2, 3, 4, 5 }; 
//             int[] vetor4 = {}; // Vetor vazio

//             // Acessando elementos
//             System.Console.WriteLine(vetor2[4]); // Isso imprime 5

//             // Alterando elementos
//             vetor2[4] = 10; 
//             System.Console.WriteLine(vetor2[4]); 

//             // Percorrer o vetor
//             for (int i = 0; i < vetor3.length; i++)
//             {
//                 System.Console.WriteLine(vetor3[i]);
//             }

//             // Percorrendo o vetor com foreach
//             foreach (int i in vetor3)
//             {
//                 System.Console.WriteLine(i);
//             }

//             // Percorrer o vetor com while
//             int i = 0;
//             while (i < vetor3.length)
//             {
//                 System.Console.WriteLine(vetor3[i]);
//             }

//             //Percorrer o vetor com do while
//             i = 0;
//             do
//             {
//                 i++;
//             } while (i < vetor3.length);

//         }
//     }
// }