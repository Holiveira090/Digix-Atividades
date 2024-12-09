using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO_ExEmpregado
{
    public class Assalariado : Empregado
    {
        public double Salario;

        public Assalariado(string nome, string sobrenome, string cpf, double salario) : base(nome, sobrenome, cpf)
        {
            this.Salario = salario;
        }
        public override double Vencimento()
        {
            return Salario;
        }
        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Sobrenome: {Sobrenome}");
            System.Console.WriteLine($"CPF: {CPF}");
            System.Console.WriteLine($"Salario: {Vencimento():C}");
            System.Console.WriteLine("--------------------------------------");
        }
    }
}