// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace Atividades_02_01
// {
//     public class Executar
//     {
//         static void Main(string[] args)
//         {
//             // Criando alguns veículos
//             Veiculo caminhao = new Caminhao("Scania R", 200, 3);
//             Veiculo carro = new CarroDePasseio("Fusca", 50, "A");
//             Veiculo utilitario = new Utilitario("Furgão Fiat", 80, "Furgão");
//             Veiculo moto = new Moto("Yamaha", 40, 250);

//             // Exibindo o valor de locação diária
//             Console.WriteLine($"Valor do Caminhão: R${caminhao.CalcularValorLocacao()}");
//             Console.WriteLine($"Valor do Carro de Passeio: R${carro.CalcularValorLocacao()}");
//             Console.WriteLine($"Valor do Utilitário: R${utilitario.CalcularValorLocacao()}");
//             Console.WriteLine($"Valor da Moto: R${moto.CalcularValorLocacao()}");
//         }
//     }
// }