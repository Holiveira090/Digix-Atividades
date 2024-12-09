// using System;

// namespace Referencia
// {
//     class Referencia
//     {
//         static int Quadrado(int x)
//         {
//             return x * x;
//         }

//         // Usando ref para passar a variavel por referencia
//         static void QuadradoRef(ref int x)
//         {
//             x *= 2; // Dupla o valor de x
//         }
//         static int QuadradoOut(out int x)
//         {
//             x=6;
//             return x*x;
//         }

//         static void Main(string[] args)
//         {
//             int a = 10;
//             System.Console.WriteLine(Quadrado(a));
//             System.Console.WriteLine(a);
//             QuadradoRef(ref a);
//             System.Console.WriteLine(a);

//             int b;
//             System.Console.WriteLine(QuadradoOut(out b));
//         }
//     }
// }
