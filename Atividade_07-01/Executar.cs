using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Atividade_07_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vendedor v1 = new Vendedor("Ana", 2500, 3, 500, Regiao.Leste, Licenca.Aprovada, TiposEmpregados.Vendedor);
            GerenteProducao gp1 = new GerenteProducao("Roberta", 5000, 5, Regiao.Norte, Licenca.Aprovada, TiposEmpregados.GerenteProducao);
            GerenteVendas gv1 = new GerenteVendas("Paulo", 4000, 1, 1000, Regiao.Sul, Licenca.Aprovada, TiposEmpregados.GerenteVendas);

            Empregados empregados = new Empregados();
            empregados.Insere(v1);
            empregados.Insere(gp1);
            empregados.Insere(gv1);

            Console.WriteLine("Imprimindo todos os empregados:");
            empregados.Imprime();
            Console.WriteLine();

            string nomeParaBuscar = "Ana";
            Console.WriteLine($"Buscando o empregado com o nome {nomeParaBuscar}:");
            empregados.Write(nomeParaBuscar);
            Console.WriteLine();

            double folhaPagamento = empregados.FolhaPagamento();
            Console.WriteLine($"Total da folha de pagamento: {folhaPagamento}\n");

            Console.WriteLine("Testando a autorização e aumento de um Gerente de Produção:");
            gp1.Autorizar();
            Console.WriteLine($"Aumento concedido: {gp1.ConcederAumento()}");

            Console.WriteLine("Testando a autorização e aumento de um Gerente de Vendas:");
            gv1.Autorizar();
            Console.WriteLine($"Aumento concedido: {gv1.ConcederAumento()}");
            Console.WriteLine($"Licença autorizada: {gv1.AutorizarLicenca(v1)}\n");

            TiposEmpregados tipoEmpregado1 = TiposEmpregados.Vendedor;
            TiposEmpregados tipoEmpregado2 = TiposEmpregados.GerenteVendas;

            Console.WriteLine($"Tipo de empregado 1: {tipoEmpregado1}");
            Console.WriteLine($"Tipo de empregado 2: {tipoEmpregado2}");
        }
    }
}
// Faltou fazer mais funções e adaptar outras, não deu tempo, F
// Que executar porcaria