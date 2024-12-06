using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Henranca
{
    public class Funcionario
    {
        // Atributos globais de Funcionarios
        public string Nome;
        public string CPF;
        public double Salario;

        // Construtor com Parametros
        public Funcionario(string nome, string cpf, double salario)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Salario = salario;
        }

        // Metodo para calcular salario
        public virtual double GetBonificacao() // Virtual permite que a classe filha possa sobrescrever o metodo
        {
            return Salario * 0.10;
        }

        // Metodo imprimir dados
        public virtual void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"CPF: {CPF}");
            System.Console.WriteLine($"Salario: {Salario}");
            System.Console.WriteLine($"Bonificação: {GetBonificacao()}");
        }
    }
}