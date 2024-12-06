using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Henranca
{
    public class Gerente : Funcionario // No C# o extends é representado por :
    {
        // Atributos Globais do Gerente
        public string Setor;

        // Construtor com Parametros
        public Gerente(string nome, string cpf, double salario, string setor) : base(nome, cpf, salario)
        {
            // base é utilizado para chamar o construtor da classe pai
            this.Setor = setor;
        }
        public override double GetBonificacao() // Override é usado para sobrescrever a classe pai
        {
            return Salario * 0.15;
        }

        // Metodo imprimir dados
        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"CPF: {CPF}");
            System.Console.WriteLine($"Salario: {Salario:C}");
            System.Console.WriteLine($"Setor: {Setor}");
            System.Console.WriteLine($"Bonificação: {GetBonificacao():C}");
        }
        public void GerenciarEquipes()
        {
            System.Console.WriteLine("Gerenciando Equipes...");
        }
    }
}