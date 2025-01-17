// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Aula_28_Manipulacao2
// {
//     public class ClasseTask
//     {
//         // O async é quando a função é assíncrona, ou seja ela não é executada de forma que não trava o programa enquanto espera o retorno
//         //o task é uma tarefa que é executada de forma
//         static async Task Main(string[] args)
//         {
//             System.Console.WriteLine("Inicio do programa");
//             int resultado = await Somar(10, 20); // O awaité esperar o retorno da função
//             System.Console.WriteLine($"Resultado: {resultado}");
//         }

//         static Task<int> Somar(int a, int b)
//         {
//             System.Console.WriteLine("Executando a soma");
//             return Task.Run(() =>
//             {
//                 Task.Delay(2000).Wait(); // Espera 2 segundos
//                 return a + b;
//             });
//         }
//     }

// }
