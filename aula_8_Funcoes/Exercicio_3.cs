// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] vetor = { 1, 2, 3, 2, 1 };
        
//         if (EhPalindromo(vetor))
//         {
//             Console.WriteLine("O vetor é um palíndromo.");
//         }
//         else
//         {
//             Console.WriteLine("O vetor não é um palíndromo.");
//         }
//     }

//     static bool EhPalindromo(int[] vetor)
//     {
//         int inicio = 0;
//         int fim = vetor.Length - 1;

//         while (inicio < fim)
//         {
//             if (vetor[inicio] != vetor[fim])
//             {
//                 return false;
//             }
//             inicio++;
//             fim--;
//         }

//         return true;
//     }
// }
