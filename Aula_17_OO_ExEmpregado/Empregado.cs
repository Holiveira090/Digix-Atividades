using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_17_OO_ExEmpregado
{
    public abstract class Empregado
    {
        public string Nome;
        public string Sobrenome;
        public string CPF;

        // Construtor
        public Empregado(string nome, string sobrenome, string cpf)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.CPF = cpf;
        }

        public abstract double Vencimento();
        public virtual void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"Sobrenome: {Sobrenome}");
            System.Console.WriteLine($"CPF: {CPF}");
            System.Console.WriteLine($"Salario: {Vencimento():C}");
        }
    }
}