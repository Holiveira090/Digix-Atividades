using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_16_OO_Henranca
{
    public class Secretaria : Funcionario // No C# o extends é representado por :
    {
        public string Ramal;

        public Secretaria(string nome, string cpf, double salario, string ramal) : base(nome, cpf, salario)
        {
            // base é utilizado para chamar o construtor da classe pai
            this.Ramal = ramal;
        }
        
        // Metodo para calcular salario
        public override double GetBonificacao() // Override é usado para sobrescrever a classe pai
        {
            return Salario * 0.05;
        }

        public override void ImprimirDados()
        {
            System.Console.WriteLine($"Nome: {Nome}");
            System.Console.WriteLine($"CPF: {CPF}");
            System.Console.WriteLine($"Salario: {Salario:C}");
            System.Console.WriteLine($"Ramal: {Ramal}");
            System.Console.WriteLine($"Bonificação: {GetBonificacao():C}");
        }

        // Metodo para atender telefone
        public void AtenderTelefone()
        {
            System.Console.WriteLine("Atendendo telefone...");
        }

    }
    
}