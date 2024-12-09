using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO_ExEmpregado
{
    public class Comissionado : Empregado
    {
        public double TotalVenda;
        public double TaxaComissao;
        public double PrecoProduto;

        public Comissionado(string nome, string sobrenome, string cpf, double totalvenda, double taxacomissao, double precoproduto) : base(nome, sobrenome, cpf)
        {
            this.TotalVenda = totalvenda;
            this.TaxaComissao = taxacomissao;
            this.PrecoProduto = precoproduto;
        }
        public override double Vencimento()
        {
            return (PrecoProduto * TotalVenda) * (TaxaComissao/100);
        }
        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Sobrenome: {Sobrenome}");
            System.Console.WriteLine($"CPF: {CPF}");
            System.Console.WriteLine($"Total de Vendas: {TotalVenda}");
            System.Console.WriteLine($"Preço dos produtos: {PrecoProduto}");
            System.Console.WriteLine($"Taxa de Comissao: {TaxaComissao}%");
            System.Console.WriteLine($"Salario: {Vencimento():C}");
            System.Console.WriteLine("--------------------------------------");
        }
    }
}