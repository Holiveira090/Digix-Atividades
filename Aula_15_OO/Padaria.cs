// using System;
// namespace Aula_15_OO.Padaria
// {
//     public class Padaria
//     {
//         public string NomeAlimento;
//         public double Preco;
//         public string Bebidas;
//         public string Doces;
//         public DateTime DataValidade;

//         public string Encomenda()
//         {
//             return $"A Lista de encomendas é {NomeAlimento} preço: {Preco}, {Bebidas}, {Doces}";
//         }
//         public double CestaCompras(List<(string NomeAlimento, double Preco)> itens)
//         {
//             double total = 0;

//             // Itera pelos itens da lista e soma os preços
//             foreach (var item in itens)
//             {
//                 System.Console.WriteLine($"Item: {item.NomeAlimento}, Preço: {item.Preco}");
//                 total += item.Preco;
//             }
//             return total;
//         }
//     }
// }