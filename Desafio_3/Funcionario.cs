using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_3
{
    public abstract class Funcionario : IRelatorio
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public double SalarioBase { get; set; }

        public abstract double CalcularSalario();
        public abstract void GerarRelatorio();
    }
    public class Gerente : Funcionario
    {
        public double Bonus { get; set; }
        public override double CalcularSalario()
        {
            return SalarioBase * 1.2;
        }
        public void CalcularGratificacao()
        {
            System.Console.WriteLine("Foi calculado a gratificação do gerente");
        }
        public override void GerarRelatorio()
        {
            System.Console.WriteLine($"Gerente {Nome}\nSalario: {CalcularSalario():c2}");
        }
    }
    public class Vendedor : Funcionario
    {
        public double VendasRealizadas { get; set; }
        public override double CalcularSalario()
        {
            return SalarioBase + (VendasRealizadas * 0.1);
        }
        public void CalcularComissao()
        {
            System.Console.WriteLine("Foi calculado a comissão");
        }
        public override void GerarRelatorio()
        {
            System.Console.WriteLine($"Vendedor {Nome}\nSalario: {CalcularSalario():c2}");
        }
    }
    public class Padeiro : Funcionario
    {
        public int HorasNoturnasTrabalhadas { get; set; }
        public override double CalcularSalario()
        {
            double AdicionalNoturno = HorasNoturnasTrabalhadas * (SalarioBase * 0.25/160);
            return SalarioBase + AdicionalNoturno;
        }
        public void CalcularProducao()
        {
            System.Console.WriteLine("Foi calculado a produção");
        }
        public override void GerarRelatorio()
        {
            System.Console.WriteLine($"Padeiro {Nome}\nSalario: {CalcularProducao:c2}");
        }
    }
}