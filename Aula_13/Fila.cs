// using System;
// namespace Lista
// {
//     public class Fila
//     {
//         static int [] fila = new int[10];
//         static int inicio = 0; // inicio da fila
//         static int fim = 0; // fim da fila
//         static int count = 0; // quantidades de elementos na fila
//         // Adicionar elemento na fila, Emqueue
//         public static void Adicionar(int valor)
//         {
//             if(count < fila.Length)
//             {
//                 fila[fim] = valor;
//                 fim = (fim + 1) % fila.Length; // Move o fim para o proximo elemento
//                 count ++; // incrementa a quantidade de elementos na fila
//             }
//             else
//             {
//                 System.Console.WriteLine("Fila cheia!");
//             }
//         }
//         public static void remover()
//         {
//             if(count > 0)
//             {
//                 fila[inicio] = 0;
//                 inicio = (inicio + 1) % fila.Length;
//                 count--;
//             }
//             else
//             {
//                 System.Console.WriteLine("Fila vazia!");
//             }
//         }
//         // Mostra a fila de forma do inicio ao fim
//         public static void Mostrar()
//         {
//             for (int i = 0; i < count; i++)
//             {
//                 System.Console.WriteLine(fila[(inicio + i) % fila.Length]);
//             }
//         }
//         // Primeiro elemento da fila
//         public static void Primeiro()
//         {
//             if(count > 0)
//             {
//                 System.Console.WriteLine(fila[inicio]);
//             }
//             else
//             {
//                 System.Console.WriteLine("Fila vazia!");
//             }
//         }
//         public static void Main(string[] args)
//         {
//             Adicionar(10);
//             Adicionar(20);
//             Adicionar(30);
//             Adicionar(40);
//             Adicionar(50);
//             Adicionar(60);
//             Adicionar(70);
//             Adicionar(80);
//             Adicionar(90);
//             Adicionar(100);

//             Mostrar();
//             System.Console.WriteLine("Primeiro elemento: ");
//             Primeiro();
//             System.Console.WriteLine("Removendo o primeiro elemento");
//             remover();
//             Mostrar();
//             System.Console.WriteLine("Removendo tudo: ");
//             while (count > 0)
//             {
//                 remover();
//             }
//             Primeiro();
//         }

//     }
// }