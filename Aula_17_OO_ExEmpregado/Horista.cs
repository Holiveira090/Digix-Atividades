using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO_ExEmpregado
{
    public class Horista : Empregado
    {
        public double PrecoHora;
        public double horasTrabalhadas;

        public Horista(string nome, string sobrenome, string cpf, double precoHora, double horastrabalhadas) : base(nome, sobrenome, cpf)
        {
            this.PrecoHora = precoHora;
            this.horasTrabalhadas = horastrabalhadas;
        }
        public override double Vencimento()
        {
            return PrecoHora * horasTrabalhadas;
        }
        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Sobrenome: {Sobrenome}");
            System.Console.WriteLine($"CPF: {CPF}");
            System.Console.WriteLine($"Preço por horas trabalhadas: {PrecoHora}");
            System.Console.WriteLine($"Quantidade de horas trabalhadas: {horasTrabalhadas}");
            System.Console.WriteLine($"Salario: {Vencimento():C}");
            System.Console.WriteLine("--------------------------------------");
        }
        
    }
}