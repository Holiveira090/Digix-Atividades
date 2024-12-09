// using System;

// namespace Funcoes_Flexiveis
// {
//     class Funcoes_Flexiveis
//     {
//         // Declarando uma delegate
//         public delegate int Operacao(int a, int b);

//         // Expressão lambda
//         static int Soma(int a, int b) => a + b;
//         // Isso é o mesmo que isso aqui
//         // static int Soma(int a, int b)
//         // {
//         //     return a + b;
//         // }

//         //Juntar 2 funções
//         public delegate void Notificar();
//         public static void EnvioEmail() => System.Console.WriteLine("Email enviado");
//         public static void EnvioSMS() => System.Console.WriteLine("SMS enviado");

//         static void Main(string[] args)
//         {
//             Operacao op = Soma;
//             System.Console.WriteLine(op(3, 2));

//             // Atribuir diretamente a expressão lambda
//             Operacao op2 = (int a, int b) => a * b;
//             System.Console.WriteLine(op2(3, 2));

//             // Método anônimo
//             Func<int, int, int> op3 = delegate(int a, int b) {return a - b; };
//             System.Console.WriteLine(op3(3, 2));

//             Notificar ntf = EnvioEmail;
//             ntf += EnvioSMS;
//             ntf();
//         }
//     }
// }
