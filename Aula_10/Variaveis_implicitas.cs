// using System;

// namespace Implicitas
// {
//     class Implicitas
//     {
//         static void Main(string[] args)
//         {
//             // Variavel implicita é uma variavel que pode receber qualquer tipo de dados
//             var nome = "c#";
//             System.Console.WriteLine(nome);
//             System.Console.WriteLine(nome.GetType());
//             var idade = 20;
//             System.Console.WriteLine(idade);
//             System.Console.WriteLine(idade.GetType());
//             var altura = 1.70;
//             System.Console.WriteLine(altura);
//             System.Console.WriteLine(altura.GetType());
//             // Const é uma variavel que não muda
//             const double pi = 3.1415;
//             System.Console.WriteLine(pi);
//             System.Console.WriteLine(pi.GetType());

//             // lista
//             var lista = new List<int> {1, 2, 3, 4, 5};
//             System.Console.WriteLine(lista.GetType());
//             // Função para listar listas
//             foreach (var item in lista)
//             {
//                 System.Console.WriteLine(item);
//             }

//             // Dicionário
//             var dicionario = new Dictionary<string, int>
//             {
//                 {"C#", 1},
//                 {"Java", 2},
//                 {"Python", 3}
//             };
//             System.Console.WriteLine(dicionario.GetType());
//             foreach (var item2 in dicionario)
//             {
//                 System.Console.WriteLine(item2);
//             }
//         }
//     }
// }
