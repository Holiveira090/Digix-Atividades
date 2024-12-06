using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Limpeza limpeza = new Limpeza("Detergente", 2.00, 5);
            Petiscos petiscos = new Petiscos("Presunto", 3.50, 3);
            Laticinios laticinios = new Laticinios("Leite", 4.00, 4);
            Carnes carnes = new Carnes("Picanha", 40, 2);
            Ferramentas ferramentas = new Ferramentas("Serrote", 50, 2);

            System.Console.WriteLine(petiscos.ListarInfo());
            System.Console.WriteLine(limpeza.ListarInfo());
            System.Console.WriteLine(laticinios.ListarInfo());
            System.Console.WriteLine(carnes.ListarInfo());
            System.Console.WriteLine(ferramentas.ListarInfo());

            // Maior Valor do estoque

            double maiorValor = Math.Max(petiscos.CalcularEstoque(),
                                          Math.Max(limpeza.CalcularEstoque(),
                                                   Math.Max(laticinios.CalcularEstoque(),
                                                            Math.Max(carnes.CalcularEstoque(),
                                                                     ferramentas.CalcularEstoque()))));
            
            System.Console.WriteLine($"O maior valor é: {maiorValor:C}");

        }
    }
}