using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Henranca
{
    public class Telefonista : Funcionario // No C# o extends é representado por :
    {
        public string EstacaoDeTrabalho;

        public Telefonista(string nome, string cpf, double salario, string estacao) : base(nome, cpf, salario)
        {
            // base é utilizado para chamar o construtor da classe pai
            this.EstacaoDeTrabalho = estacao;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.05;
        }

        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"CPF: {CPF}");
            System.Console.WriteLine($"Salario: {Salario:C}");
            System.Console.WriteLine($"Estação de trabalho: {EstacaoDeTrabalho}");
            System.Console.WriteLine($"Bonificação: {GetBonificacao():C}");
        }

        public void AtenderTelefone()
        {
            System.Console.WriteLine("Atendendo telefone...");
        }



    }
}