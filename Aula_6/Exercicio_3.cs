// using System;

// namespace Exercico_3
// {
//     class Exercico_3
//     {
//         static void Main(string[] args)
//         {  
//             Random r = new Random();
//             int[,] matriz = new int[4, 4] 
//             {
//                 {r.Next(10), r.Next(10), r.Next(10), r.Next(10)}, 
//                 {r.Next(10), r.Next(10), r.Next(10), r.Next(10)},
//                 {r.Next(10), r.Next(10), r.Next(10), r.Next(10)},
//                 {r.Next(10), r.Next(10), r.Next(10), r.Next(10)}
//             };
//             int maior = int.MinValue;
//             int menor = int.MaxValue;
            
//             for (int i = 0; i < 4; i++)
//             {
//                 for (int j = 0; j < 4; j++)
//                 {
//                     if (matriz[i, j] > maior)
//                     {
//                         maior = matriz[i, j];
//                     }
//                     if (matriz[i, j] < menor)
//                     {
//                         menor = matriz[i, j];
//                     }
//                 }
//             }

//             Console.WriteLine($"O maior número é {maior}");
//             Console.WriteLine($"O menor número é {menor}");
//             Console.WriteLine($"A soma dos dois é {maior + menor}");
//         }
//     }
// }
