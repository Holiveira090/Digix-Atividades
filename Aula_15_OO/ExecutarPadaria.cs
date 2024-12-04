// using System;
// using System.Data;
// namespace Aula_15_OO.Padaria
// {
//     class Executar
//     {
//         static void Main(string[] args)
//         {
//             Padaria padaria = new Padaria();
//             padaria.NomeAlimento = "coxinha";
//             padaria.Preco = 5.60;
//             padaria.Bebidas = "café";
//             padaria.Doces = "Sonho";
//             padaria.DataValidade = DateTime.Now.AddDays(3);

//             // Exibindo os detalhes da encomenda
//             System.Console.WriteLine(padaria.Encomenda());

//             // Criando uma lista de compras com nome em preço
//             List<(string NomeAlimento, double Preco)> listasCompras = new List<(string NomeAlimento, double Preco)>
//             {
//                 ("Pão Frances", 5.98),
//                 ("Bolo de Cenoura", 20.50),
//                 ("Coxinha", 4.50),
//                 ("Suco Natural", 10.20)
//             };
//             // Calculando o total das cestas
//             double total = padaria.CestaCompras(listasCompras);
//             System.Console.WriteLine($"Total de cestas de compras R${total}");
//         }
//     }
// }